﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoAdo
{
    public static class ExtensionsString
    {
        public static string Tronquer(this string valeur, int nombreCaracteres)
        {
            const string points = "...";
            return valeur.Length <= nombreCaracteres
                ? valeur
                : valeur.Substring(0, nombreCaracteres - points.Length) + points;
        }
    }
}
