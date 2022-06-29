using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager
{
    public static void Playsound()
    {
        GameObject SoundGameObject = new GameObject("Sound");
        AudioSource audioSource = SoundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GameAssets.i.PlayerJump);
    }

}
