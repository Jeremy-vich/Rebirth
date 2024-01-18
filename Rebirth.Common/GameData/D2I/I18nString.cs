using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rebirth.Common.GameData.D2I
{
    internal class I18nString : INotifyPropertyChanged
    {
        private readonly I18nDataManager manager;
        private bool shouldRefresh = true;

        public I18nString(int id, I18nDataManager manager)
        {
            this.manager = manager;
            Id = id;
        }

        public I18nString(string id, I18nDataManager manager)
        {
            this.manager = manager;
            IdString = id;
        }

        /// <summary>
        /// Used if IdString == null
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// If null, Id is used
        /// </summary>
        public string IdString
        {
            get;
            set;
        }

        private string text;

        public string Text
        {
            get
            {
                if (shouldRefresh)
                    Refresh();

                return text;
            }
        }

        private Languages language;

        /// <summary>
        /// Default if null
        /// </summary>
        public Languages Language
        {
            get { return language; }
            set
            {
                if (language != value)
                    Refresh();
                language = value;
            }
        }

        /// <summary>
        /// Update the Text property
        /// </summary>
        public void Refresh()
        {
            if (IdString != null)
                text = I18nDataManager.Instance.ReadText(IdString, Language);
            else
                text = I18nDataManager.Instance.ReadText(Id, Language);

            shouldRefresh = false;
        }

        public static implicit operator string(I18nString instance)
        {
            return instance.Text;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
