using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Storage;

public class DLC : MonoBehaviour
{
    [SerializeField] public string imgName;
    // Start is called before the first frame update
    void Start()
    {
        FirebaseStorage storage = FirebaseStorage.DefaultInstance;

        StorageReference storageReference = storage.GetReferenceFromUrl("gs://cgnicolaicaruana.appspot.com/DLC");
        StorageReference squareRef = storageReference.Child("Square.png");
        StorageReference circleRef = storageReference.Child("circle.png");

        if (imgName.Equals("Square"))
        {
            StartCoroutine(DownloadImage(squareRef));
        }

        if (imgName.Equals("Circle"))
        {
            StartCoroutine(DownloadImage(circleRef));
        }
    }

    IEnumerator DownloadImage(StorageReference reference)
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
