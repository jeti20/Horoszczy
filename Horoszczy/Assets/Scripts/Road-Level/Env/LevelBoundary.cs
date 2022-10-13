using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -8.5f; //"static", pozwoli dowolnemu skryptowi na interakcjê z t¹ zmienn¹ w najprostszy sposób. Kiedy jest statyczna, inne skrypty mog¹ wchodziæ w interakcje z t¹ zmienn¹
    public static float rightSide = 8.5f;
    public float internalLeft;
    public float internalRight;
    // Update is called once per frame
    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
