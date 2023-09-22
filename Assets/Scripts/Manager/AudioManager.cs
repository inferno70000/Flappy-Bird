using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class AudioManager : AbstractMonoBehaviour
{
    private static AudioManager instance;
    [SerializeField] private AudioSource audioSource;

    public static AudioManager Instance { get => instance; }
    public AudioSource AudioSource { get => audioSource; }

    public const string FlapSound = "Flap";
    public const string HitSound = "Hit";
    public const string ScoreSound = "Score";

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Only 1 Input Manager exists");
        }

        instance = this;
    }

    protected override void LoadComponent()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
    }

    public void PlaySound(string sound)
    {
        audioSource.clip = Resources.Load<AudioClip>("Sound/" + sound);
        audioSource.Play();
    }
}
