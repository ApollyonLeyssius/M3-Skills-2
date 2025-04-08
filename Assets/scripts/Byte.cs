using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] bit[] bits = new bit[8];
    [SerializeField] int value = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bin2dec();
    }
    public string getHex()
    {
        string HexValue = value.ToString("X2");
        return HexValue;
    }

    public void Bin2dec()
    {
        this.value = 0;
        if(bits[0].state) { value += 1; }
        if (bits[1].state) { value += 2; }
        if (bits[2].state) { value += 4; }
        if (bits[3].state) { value += 8; }
        if (bits[4].state) { value += 16; }
        if (bits[5].state) { value += 32; }
        if (bits[6].state) { value += 64; }
        if (bits[7].state) { value += 128; }

    }

    public void SetByte(int NewValue)
    {
        if (NewValue > 255)
        {
            NewValue = 255;
        }

        value = NewValue;

        if (NewValue >= 128)
        {
            bits[7].state = true;
            NewValue -= 128;
        }

        else
        {
            bits[7].state = false;
        }

        if (NewValue >= 64)
        {
            bits[6].state = true;
            NewValue -= 64;
        }

        else
        {
            bits[6].state = false;
        }

        if (NewValue >= 32)
        {
            bits[5].state = true;
            NewValue -= 32;
        }

        else
        {
            bits[5].state = false;
        }

        if (NewValue >= 16)
        {
            bits[4].state = true;
            NewValue -= 16;
        }

        else
        {
            bits[4].state = false;
        }

        if (NewValue >= 8)
        {
            bits[3].state = true;
            NewValue -= 8;
        }

        else
        {
            bits[3].state = false;
        }

        if (NewValue >= 4)
        {
            bits[2].state = true;
            NewValue -= 4;
        }

        else
        {
            bits[2].state = false;
        }

        if (NewValue >= 2)
        {
            bits[1].state = true;
            NewValue -= 2;
        }

        else
        {
            bits[1].state = false;
        }

        if (NewValue >= 1)
        {
            bits[0].state = true;
            NewValue -= 1;
        }

        else
        {
            bits[0].state = false;
        }
    }
}
