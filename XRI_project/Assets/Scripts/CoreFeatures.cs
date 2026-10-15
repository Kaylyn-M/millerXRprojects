using Oculus.VoiceSDK.UX;
using UnityEngine;

public enum FeatureUsage
{
    Once, //use once
    Toggle //use more than once
}

public class CoreFeatures : MonoBehaviour
{
    //Accessirs - Accessing code outside of this specific class
    //This can be done with public variables, this is a more condensed approach.
    //PROPERTIES - Encapsulates filed
    //GET Accessor (Read) - Returns encapsulated values
    //SET Acessor (WRITE) - allocates/assigns new values to a field.
    //Camel, pascal, kebab, snake. kaylynMiller, KaylynMiller, kaylyn-miller,kaylyn_miller
    //Note: Must use Pascal case for Property - example: PropertyName

    public bool AudioSFXSourceCreated {  get; set; }

    [field: Header("Core Audio")]
    //Audio plays when door opens
    [field: SerializeField]

    public AudioClip AudioClipOnStart {  get; set; }

    //Audio plays on exit
    [field: SerializeField]
    public AudioClip AudioClipOnEnd { get; set; }

    private AudioSource audioSource;

    [Header("Core Features")]
    public FeatureUsage featureUsage = FeatureUsage.Once;

    protected virtual void Awake()
    {
        MakeSFXAudioSource();
    }

    private void MakeSFXAudioSource()
    {
        audioSource = GetComponent<AudioSource>();

        //if this is equal to null, create it here

        //=== means is exactly equal to
        if(audioSource == null)
        {
            audioSource= gameObject.AddComponent<AudioSource>();
        }

        //whether its null or not, we need to still make sure it's true
        //On Awake, be sure to create this audio source
        AudioSFXSourceCreated = true; 
    }
    //Audio Play commands
    protected void PlayOnStart()
    {
        if (AudioSFXSourceCreated && AudioClipOnStart != null)
        {
            //I have a source, but I need to associate it with a clip
            audioSource.clip = AudioClipOnStart;
            audioSource.Play();
        }

    }
    protected void PlayOnEnd()
    {
        if (AudioSFXSourceCreated && AudioClipOnEnd != null)
        {
            audioSource.clip = AudioClipOnEnd;
            audioSource.Play();
        }
    }    
}

