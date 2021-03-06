﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetMetier
{
    public class GestionnaireDeCaves
    {
        private Dictionary<string, List<Bouteille>> lesCaves;

        public GestionnaireDeCaves()
        {
            LesCaves = new Dictionary<string, List<Bouteille>>();
        }

        public Dictionary<string, List<Bouteille>> LesCaves { get => lesCaves; set => lesCaves = value; }

        public void AjouterCave(string unNomDeCave,List<Bouteille> lesBouteillesDeLaCave)
        {
            // A vous de jouer
            LesCaves.Add(unNomDeCave, lesBouteillesDeLaCave);
        }

        public int NbBouteilles(string unNomDeCave)
        {
            // A vous de jouer
            // on déclare la variable
            int nbBouteille = 0;

            foreach(Bouteille bout in lesCaves[unNomDeCave])
            {
                nbBouteille = nbBouteille + 1;
            }
            return nbBouteille;
        }

        public int NbBouteillesDeRouges(string unNomDeCave)
        {
            // A vous de jouer
            int nbBouteilleRouge = 0;

            foreach(Bouteille bout in lesCaves[unNomDeCave])
            {
                nbBouteilleRouge = nbBouteilleRouge + 1;
            }
            return nbBouteilleRouge;
        }

        public double ValeurDeLaCave(string unNomDeCave)
        {
            // A vous de jouer
            return 0;
        }
    }
}
