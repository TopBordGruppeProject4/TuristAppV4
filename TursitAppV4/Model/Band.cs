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
    public class Band: INotifyPropertyChanged
    {
        public string Navn { get; set; }
        public string Beskrivelse { get; set; }

        public Band(string navn, string beskrivelse)
        {
            Navn = navn;
            Beskrivelse = beskrivelse;
        }

        public override string ToString()
        {
            return Navn.ToString(); //string.Format("Navn: {0}, Beskrivelse: {1}", Navn, Beskrivelse);
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
