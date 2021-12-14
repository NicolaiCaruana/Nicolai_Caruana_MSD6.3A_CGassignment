using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Firebase.Database;
using Firebase.Storage;
using Firebase.Extensions;

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

        else if (imgName.Equals("Circle"))
        {
            StartCoroutine(DownloadImage(circleRef));
        }
    }

    IEnumerator DownloadImage(StorageReference reference)
    {
        const long maxAllowedSize = 1 * 1024 * 1024;
        reference.GetBytesAsync(maxAllowedSize).ContinueWithOnMainThread(task =>
        {
            if (task.IsFaulted || task.IsCanceled)
            {
                Debug.LogException(task.Exception);
            }

            else
            {
                byte[] Contents = task.Result;

                Texture2D texture = new Texture2D(1, 1);
                texture.LoadImage(Contents);

                Sprite sprite = Sprite.Create(texture, new Rect(0f, 0f, texture.width, texture.height), new Vector2(1f, 1f), 100f);

                GetComponent<SpriteRenderer>().sprite = sprite;
            }
        });

        yield return null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
