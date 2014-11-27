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
    public class Koncert: INotifyPropertyChanged
    {
        public Band Band { get; set; }
        public string Tidspunkt { get; set; }
        public string Dato { get; set; }
        public Spillested Spillested { get; set; }

        public Koncert(Band band, string tidspunkt, string dato, Spillested spillested)
        {
            Band = band;
            Tidspunkt = tidspunkt;
            Dato = dato;
            Spillested = spillested;
        }

        public override string ToString()
        {
            return Band.ToString();
                //string.Format("Band: {0}, Tidspunkt: {1}, Dato: {2}, Spillested: {3}", Band, Tidspunkt, Dato, Spillested);
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
