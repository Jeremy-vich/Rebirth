using Microsoft.VisualBasic.FileIO;
using Rebirth.Common.Dispatcher;
using Rebirth.Common.Extensions;
using Rebirth.Common.GameData.D2O;
using Rebirth.Common.Network;
using Rebirth.Common.Protocol.Data;
using Rebirth.Common.Protocol.Enums;
using Rebirth.Common.Protocol.Messages;
using Rebirth.Common.Protocol.Types;
using Rebirth.Common.Thread;
using Rebirth.World.Managers;
using Rebirth.World.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.World.Frames
{
    public class ApproachFrame
    {
        [MessageHandler(AuthenticationTicketMessage.Id)]
        private void HandleAuthenticationTicketMessage(Client client, AuthenticationTicketMessage msg)
        {
            byte[] test = msg.ticket.Split(',').Select(x => byte.Parse(x)).ToArray();
            var str = Encoding.Default.GetString(test);
            if (string.IsNullOrEmpty(str)){
                client.Send(new AuthenticationTicketRefusedMessage());
                return;
            }
            var acc = AccountManager.Instance.Get(str);
            if (acc is null)
                client.Send(new AuthenticationTicketRefusedMessage());
            else
            {
                client.Account = acc;
                client.Send(new AuthenticationTicketAcceptedMessage());
            }
        }

        const string consonne = "qwrtpsdfghjklzxcvbnm";
        const string voyelle = "aeiouy";
        [MessageHandler(CharacterNameSuggestionRequestMessage.Id)]
        private void HandleCharacterNameSuggestionRequestMessage(Client client, CharacterNameSuggestionRequestMessage msg)
        {
            var rdn = new AsyncRandom();
            string result = string.Empty;
            switch (rdn.Next(0, 3))
            {
                case 1:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                case 2:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                case 3:
                    result += voyelle[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
                default:
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += "-";
                    result += consonne[rdn.Next(0, consonne.Length)].ToString().ToUpper();
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    result += voyelle[rdn.Next(0, voyelle.Length)];
                    result += consonne[rdn.Next(0, consonne.Length)];
                    break;
            }
            client.Send(new CharacterNameSuggestionSuccessMessage(result));
        }

        [MessageHandler(CharactersListRequestMessage.Id)]
        private void HandleCharactersListRequestMessage(Client client, CharactersListRequestMessage msg)
        {
            client.Send(new ServerOptionalFeaturesMessage(Array.Empty<sbyte>()));

            List<int> list = new List<int>();
            list.Add((int)BreedEnum.Pandawa);
            list.Add((int)BreedEnum.Cra);
            list.Add((int)BreedEnum.Eniripsa);
            list.Add((int)BreedEnum.Enutrof);
            list.Add((int)BreedEnum.Iop);
            list.Add((int)BreedEnum.Ecaflip);
            list.Add((int)BreedEnum.Sadida);
            list.Add((int)BreedEnum.Sram);
            list.Add((int)BreedEnum.Osamodas);
            list.Add((int)BreedEnum.Feca);
            list.Add((int)BreedEnum.Zobal);
            list.Add((int)BreedEnum.Roublard);
            list.Add((int)BreedEnum.Sacrieur);
            list.Add((int)BreedEnum.Xelor);
            list.Add((int)BreedEnum.Ouginak);
            list.Add((int)BreedEnum.Steamer);
            list.Add((int)BreedEnum.Huppermage);
            list.Add((int)BreedEnum.Eliotrope);

            uint lol = 0;
            foreach (var t in list)
                lol += (uint)Math.Pow(2, t - 1);

            list.Clear();
            list.Add((int)BreedEnum.Feca);
            list.Add((int)BreedEnum.Pandawa);
            list.Add((int)BreedEnum.Cra);
            list.Add((int)BreedEnum.Eniripsa);
            list.Add((int)BreedEnum.Enutrof);
            list.Add((int)BreedEnum.Iop);
            list.Add((int)BreedEnum.Ecaflip);

            uint avai = 0;
            foreach (var t in list)
                avai += (uint)Math.Pow(2, t - 1);

            client.Send(new AccountCapabilitiesMessage(false, 
                true, 
                client.Account.Id, 
                lol, 
                avai, 
                1
            ));
            //client.Send(new TrustStatusMessage(true));

            var chrs = CharacterManager.Instance.GetAll(client.Account.Id);
            client.Send(new CharactersListMessage(chrs.Select(x => x.CharacterBaseInformations).ToArray(), false));
        }

        [MessageHandler(CharacterCanBeCreatedRequestMessage.Id)]
        private void HandleCharacterCanBeCreatedRequestMessage(Client client, CharacterCanBeCreatedRequestMessage msg)
        {
            if (CharacterManager.Instance.Count(client.Account.Id) >= 5)
            {
                client.Send(new CharacterCanBeCreatedResultMessage() { yesYouCan = false });
                return;
            }
            client.Send(new CharacterCanBeCreatedResultMessage() { yesYouCan = true });
        }

        [MessageHandler(CharacterCreationRequestMessage.Id)]
        private void HandleCharacterCreationRequestMessage(Client client, CharacterCreationRequestMessage msg)
        {
            if (CharacterManager.Instance.Count(client.Account.Id) >= 5) 
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_TOO_MANY_CHARACTERS));
                return;
            }
            if (CharacterManager.Instance.HasName(msg.name))
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_NAME_ALREADY_EXISTS));
                return;
            }
            if(msg.breed < 1 || msg.breed > 14)
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_NO_REASON));
                return;
            }
            if (!CharacterManager.Instance._nameCheckerRegex.IsMatch(msg.name))
            {
                client.Send(new CharacterCreationResultMessage((sbyte)CharacterCreationResultEnum.ERR_INVALID_NAME));
                return;
            }

            var breed = ObjectDataManager.Get<Breed>(msg.breed);

            var entityLook = (msg.sex ? breed.femaleLook.Split('|') : breed.maleLook.Split('|'));

            var chr = new Character()
            {
                AccountId = client.Account.Id,
                BreedId = (byte)msg.breed,
                EntityLook = $"{entityLook[0]}|" +
                $"{entityLook[1]},{ObjectDataManager.Get<Head>((int)msg.cosmeticId).skins}" +
                $"|{string.Join(',', msg.colors.Select((x, i) => x > 0 ? x : (msg.sex ? (int)breed.femaleColors[i] : (int)breed.maleColors[i])))}" +
                $"|{entityLook[3]}",
                Name = msg.name,
                Sex = msg.sex,
                MapId = 154010883,
                CellId = 370,
                Direction = DirectionsEnum.DIRECTION_SOUTH_EAST
            };
            chr.Init();
            CharacterManager.Instance.Save(chr);
            JobsManager.Instance.Create(chr.Id);

            foreach (var spell in breed.breedSpellsId)
                SpellsManager.Instance.Save(new Models.Spell()
                {
                     CharacterId = chr.Id,
                     Level = 1,
                     SpellId = (int)spell
                });

            client.Character = chr;

            client.Send(new CharacterSelectedSuccessMessage(chr.CharacterBaseInformations, false));
            WorldManager.Instance.Enter(client);
        }

        [MessageHandler(CharacterDeletionRequestMessage.Id)]
        private void HandleCharacterDeletionRequestMessage(Client client, CharacterDeletionRequestMessage msg)
        {
            var chr = CharacterManager.Instance.Get((int)msg.characterId);
            if(chr == null || chr.AccountId != client.Account.Id)
            {
                client.Send(new CharacterDeletionErrorMessage((sbyte)CharacterDeletionErrorEnum.DEL_ERR_NO_REASON));
                return;
            }
            var myMdr5 = $"{chr.Id}~{client.Account.SecretAnswer}".GetMD5().ToLower();
            if (chr.Exp >= 171000 && myMdr5 != msg.secretAnswerHash.ToLower())
            {
                client.Send(new CharacterDeletionErrorMessage((sbyte)CharacterDeletionErrorEnum.DEL_ERR_BAD_SECRET_ANSWER));
                return;
            }
            foreach (var spell in chr.Spells)
                SpellsManager.Instance.Delete(spell.Id);
            CharacterManager.Instance.Delete(chr.Id);
            var chrs = CharacterManager.Instance.GetAll(client.Account.Id);
            client.Send(new CharactersListMessage(chrs.Select(x => new CharacterBaseInformations(x.Id, x.Name, 1, new Models.EntityLook(x.EntityLook).GetEntityLook(), x.BreedId, x.Sex)).ToArray(), false));
        }
    
        [MessageHandler(CharacterSelectionMessage.Id)]
        private void HandleCharacterSelectionMessage(Client client, CharacterSelectionMessage msg)
        {
            var chr = CharacterManager.Instance.Get((int)msg.id);
            if(chr == null || client.Account.Id != chr.AccountId)
            {
                client.Send(new CharacterSelectedErrorMessage());
                return;
            }

            client.Character = chr;

            //client.Send(new NotificationListMessage(new int[0]));
            client.Send(new CharacterSelectedSuccessMessage(chr.CharacterBaseInformations, false));

            WorldManager.Instance.Enter(client);
        }
    }
}
