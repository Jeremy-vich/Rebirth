using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.World.Frames;
using Rebirth.World.Models;
using System.Drawing;
using Item = Rebirth.Common.Protocol.Data.Item;

namespace Rebirth.World.Managers
{
    public class WorldManager : DataManager<WorldManager>
    {
        
        public void Enter(Client client)
        {
            if(client.Character == null)
            {
                client.Disconnect();
                return;
            }

            var friends = ClientsManager.Instance.GetAll(x => x.Account.Friends.Any(z => z.accountId == client.Account.Id));
            foreach (var friend in friends)
                friend.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 143, new string[2] { client.Account.Username, client.Character.Name }));

            client.RemoveFrame(typeof(ApproachFrame));
            client.AddFrame(typeof(SocialFrame));
            client.AddFrame(typeof(ContextFrame));
            client.AddFrame(typeof(PrismFrame));
            client.AddFrame(typeof(InteractiveFrame));
            client.AddFrame(typeof(TitleOrnamentFrame));
            client.AddFrame(typeof(ChatFrame));

            if (client.Account.IsAdmin)
                client.AddFrame(typeof(AdminFrame));

            client.Send(new InventoryContentMessage(client.Character.Items.Select(x => x.ObjectItem).ToArray(), (uint)client.Character.Kamas));
            client.Send(new ShortcutBarContentMessage((sbyte)ShortcutBarEnum.GENERAL_SHORTCUT_BAR, new Shortcut[0]));
            client.Send(new ShortcutBarContentMessage((sbyte)ShortcutBarEnum.SPELL_SHORTCUT_BAR, new Shortcut[0]));
            client.Send(new RoomAvailableUpdateMessage(1));
            client.Send(new HavenBagPackListMessage(new sbyte[0]));
            client.Send(new EmoteListMessage(client.Character.Emotes.Select(x => (byte)x.EmoteId).ToArray()));


            client.Send(new JobDescriptionMessage(client.Character.Jobs.Select(x => x.JobDescription).ToArray()));
            client.Send(new JobExperienceMultiUpdateMessage(client.Character.Jobs.Select(x => x.JobExperience).ToArray()));
            client.Send(new JobCrafterDirectorySettingsMessage(client.Character.Jobs.Select(x => x.JobCrafterDirectorySetting).ToArray()));
            
            
            client.Send(new AlignmentRankUpdateMessage(0, false));
            client.Send(new DareCreatedListMessage(new DareInformations[0], new DareVersatileInformations[0]));
            client.Send(new DareSubscribedListMessage(new DareInformations[0], new DareVersatileInformations[0]));
            client.Send(new DareWonListMessage(new double[0]));
            client.Send(new DareRewardsListMessage(new DareReward[0]));

            var list = new List<PrismSubareaEmptyInfo>();
            foreach (var item in ObjectDataManager.GetAll<SubArea>())
            {
                if(item.capturable)
                    list.Add(new PrismSubareaEmptyInfo((uint)item.id, 0));
            }
            client.Send(new PrismsListMessage(list.ToArray()));

            if(client.Account.IsAdmin)
                client.Send(new EnabledChannelsMessage(new sbyte[0], new sbyte[0]));
            else
                client.Send(new EnabledChannelsMessage(new sbyte[0], new sbyte[] { 8 }));
            client.Send(new SpellListMessage(true, client.Character.SpellsItem));
            client.Send(new ShortcutBarContentMessage((sbyte)ShortcutBarEnum.SPELL_SHORTCUT_BAR, new Shortcut[0]));
            client.Send(new InventoryWeightMessage(client.Character.Pods, client.Character.MaxPod));

            client.Send(new FriendWarnOnConnectionStateMessage(true));
            client.Send(new FriendWarnOnLevelGainStateMessage(true));
            client.Send(new FriendGuildWarnOnAchievementCompleteStateMessage(true));
            client.Send(new WarnOnPermaDeathStateMessage(true));
            client.Send(new GuildMemberWarnOnConnectionStateMessage(true));

            client.Send(new ServerExperienceModificatorMessage(500));
            client.Send(new SpouseStatusMessage(false));
            client.Send(new AchievementListMessage(new uint[0], new AchievementRewardable[0]));
            client.Send(new GameRolePlayArenaUpdatePlayerInfosMessage(new ArenaRankInfos(0, 0, 0, 0)));
            if (client.Account.IsAdmin)
                client.Send(new CharacterCapabilitiesMessage(4096));
            else
                client.Send(new CharacterCapabilitiesMessage(4095));
            client.Send(new AlmanachCalendarDateMessage(186));
            client.Send(new IdolListMessage(new uint[0], new uint[0], new PartyIdol[0]));
            client.Send(new MailStatusMessage(0, 0));
            client.Send(new StartupActionsListMessage(new StartupActionAddObject[0]));

            client.Send(new CharacterLoadingCompleteMessage());

            client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#2980b9").ToArgb():X}\"><b>Rebirth v0.1b émulateur by Neross</b>\nBienvenue sur notre serveur test.</font>"
                }));
            client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#27ae60").ToArgb():X}\">Votre dernière connexion date du <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{client.Account.LastDate:G}</font></b> avec l'ip <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{client.Account.LastIp}</font></font>"
                }));

            client.Account.LastDate = DateTime.Now;
            client.Account.LastIp = client.IP;
            AccountManager.Instance.Save(client.Account);

            var jail = client.IsJail();
            if (jail > 0)
            {
                if(!JailManager.Instance.IsInJail(client.Character.MapId))
                {
                    var jailMap = JailManager.Instance.GetMap();
                    client.Teleport(jailMap.Item1, jailMap.Item2);
                }
                client.Send(new TextInformationMessage((sbyte)TextInformationTypeEnum.TEXT_INFORMATION_MESSAGE, 0, new string[]
                {
                    $"<font color=\"#{System.Drawing.ColorTranslator.FromHtml("#e74c3c").ToArgb():X}\">Bienvenue en prison.\nVotre libération est prévue pour le : <b><font color=\"#{System.Drawing.ColorTranslator.FromHtml("#f1c40f").ToArgb():X}\">{jail.UnixTimestampToDateTime():G}</font></b></font>"
                }));
            }
            else
            {
                if(JailManager.Instance.IsInJail(client.Character.MapId))
                    client.UnJail();
                client.AddFrame(typeof(InventoryFrame));
            }
        }
    }
}
