﻿using System;

namespace Luokkakaavio
{
    public class Parkkipaikka
    {
        public DateTime parkkeerattuAika;
        private double hinta = 5;

        public Moottoriajoneuvo ajoneuvo;

        public Parkkipaikka( Moottoriajoneuvo ajoneuvo = null )
        {
            this.parkkeeraa( ajoneuvo );
        }

        public void parkkeeraa( Moottoriajoneuvo ajoneuvo )
        {
            this.ajoneuvo = ajoneuvo;
            this.parkkeerattuAika = DateTime.Now;
        }

        /*public Boolean ShouldSerializevapaa()
        {
            return false;
        }*/

        public Boolean onVarattu()
        {
            return this.ajoneuvo != null;
        }

        public Moottoriajoneuvo getOccupant()
        {
            return ajoneuvo;
        }

        // Laskee parkissa kulutetun ajan tunneissa
        // Alkeneet tunnit
        public int kulunutAika()
        {
            DateTime alku = this.parkkeerattuAika;
            DateTime loppu = DateTime.Now;

            TimeSpan kulunutaika = loppu - alku;

            return (int)kulunutaika.TotalHours;
        }

        // Laskee parkkeerauksen hinnan
        public double laskeHinta()
        {
            int tunnit = this.kulunutAika();
            return tunnit * hinta;
        }
    }
}