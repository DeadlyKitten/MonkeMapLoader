﻿using BepInEx;
using Bepinject;
using UnityEngine;

namespace VmodMonkeMapLoader
{
    [BepInPlugin("vadix.gorillatag.maploader", "Monke Map Loader", "1.0.0")]
    [BepInDependency("tonimacaroni.computerinterface", "1.3.1")]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.3.0")]
    public class MonkeMapLoaderPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            Debug.Log("Monke Map Loader started");

            HarmonyPatches.ApplyHarmonyPatches();
            Zenjector.Install<MainInstaller>().OnProject();
        }
    }
}