using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrueColor : MonoBehaviour
{
    [SerializeField] MyPixel pixel;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {


            float xRand = Random.Range(-5f, 5f);
            float yRand = Random.Range(-5f, 5f);
            Vector3 pos = new Vector3(xRand, yRand, 0);

            MyPixel copyofPixel = Instantiate(pixel, pos, Quaternion.identity);
            pixel.color = setRandomColor();
            Instantiate(pixel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        {
            for (int i = 0; i < 10; i++)
            {


                float xRand = Random.Range(-5f, 5f);
                float yRand = Random.Range(-5f, 5f);
                Vector3 pos = new Vector3(xRand, yRand, 0);

                MyPixel copyofPixel = Instantiate(pixel, pos, Quaternion.identity);
                pixel.color = setRandomColor();
                Instantiate(pixel);
            }
        }
    }

    Color setRandomColor()
    {
        float R = Random.value;
        float G = Random.value;
        float B = Random.value;

        Color newColor = new Color(R, G, B);
        return newColor;
    }
}
