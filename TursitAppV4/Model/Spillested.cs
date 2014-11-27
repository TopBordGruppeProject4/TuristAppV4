using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TursitAppV4.Annotations;

namespace TursitAppV4.Model
{
    public class Spillested: INotifyPropertyChanged
    {
        public Spillested(string navn, string hjemmeside, string adresse)
        {
            Navn = navn;
            Hjemmeside = hjemmeside;
            Adresse = adresse;
        }

        public String Navn { get; set; }
        public String Hjemmeside { get; set; }
        public String Adresse { get; set; }

        public override string ToString()
        {
            return string.Format("Navn: {0}, Hjemmeside: {1}, Adresse: {2}", Navn, Hjemmeside, Adresse);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
