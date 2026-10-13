using UnityEngine;

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
}

