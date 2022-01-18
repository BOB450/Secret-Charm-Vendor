using System;
using System.IO;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using Modding;
using ModCommon;
using UnityEngine;
using System.Security.Cryptography;
using SFCore;
using SFCore.Generics;

namespace VanillaPlusPlusCharms
{
    public class Class2 : Mod
    {
        public Class2() : base("VanillaPlusPlusCharms") { }
       // public override string GetVersion() => "0.1";
        public override void Initialize()
        {
            Log("Inits");


            ModHooks.AfterTakeDamageHook += AfterTakeDamage;


        }

        private int AfterTakeDamage(int hazardType, int damageAmount)
        {
            PlayerData pd = PlayerData.instance;
            
            return damageAmount;
        }
      



    }
}