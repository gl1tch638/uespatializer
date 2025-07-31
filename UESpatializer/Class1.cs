﻿using MelonLoader;// base ml mod support
using UnityEngine;
using Il2CppSystem;
using Il2CppInterop.Runtime;

[assembly: MelonInfo(typeof(UESpatializer.Class1), "UE Spatializer", "1.0", "gl1tch")]
[assembly: MelonGame()]

namespace UESpatializer
{

public class Class1 : MelonMod
{
    public override void OnSceneWasLoaded (int buildIndex, string scene1)
    {
        GameObject uemenu=GameObject.Find("com.sinai.unityexplorer_Root");
        // GameObject uemouseinspector=GameObject.Find("com.sinai.unityexplorer.MouseInspector_Root");
        if (uemenu!=null)
        {
            LoggerInstance.Msg("Found UE Object");
            Vector3 gameCamObj = Camera.main.transform.position;
            Camera gameCam = Camera.main;
            Canvas thecanvas = uemenu.GetComponent<Canvas>();
            thecanvas.renderMode = RenderMode.WorldSpace;
            uemenu.transform.localScale = new Vector3(0.0015f, 0.0015f, 0.0015f);
            uemenu.transform.position = ((gameCamObj) + (new Vector3(0, 0, 0)));
            LoggerInstance.Msg("preparing main camera ui interaction");
            //do the rest later lol
        }
        else
        {
            LoggerInstance.Msg("Could not find UE object");
        }

    }

}
}
