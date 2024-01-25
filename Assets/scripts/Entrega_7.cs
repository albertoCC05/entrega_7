using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Entrega_7 : MonoBehaviour
{
    //variables

    // exercice 1

    private int totalEvenNumbers = 0;

    // ex 2

   [SerializeField] private string[] stringArray;
    private int totalVowels = 0;

    // ex 4 

    private int randmoNumber;
    private int totalRandom = 0;
    private int howManyFives = 0;

    // ex 5

    private string name = "lechuga";
    private bool thereIsAa = false;


    //-------------------------------------------------------------------------------------------------------

    private void exercice1()
    {

        for (int i = 0; i <= 100; i += 2)
        {
            totalEvenNumbers += i;

            if (i == 100)
            {
                Debug.Log(totalEvenNumbers);
            }
        }
    }
    private void exercice2()
    {
        foreach (string leter in stringArray)
        {
            if (leter == "a" || leter == "e" || leter == "i" || leter == "o" || leter == "u")
            {
                totalVowels++;
            }
        }
        Debug.Log(totalVowels);
    }
    private void exercice3()
    {
        for (int i = 10; i >0; i--)
        {
            Debug.Log($"{i} green bottles Hanging on the wall {i} green bottles Hanging on the wall And if one green bottle Should accidentally fall There’ll be {i-1} green bottles Hanging on the wall");
        }
       

    }
    private void exercice4()
    {
        while (totalRandom <= 100)
        {
            randmoNumber = Random.Range(1, 10);

            totalRandom += randmoNumber; 

            if (randmoNumber == 5)
            {
                howManyFives++;
            }
        }
        Debug.Log(totalRandom);
    }
    private void exercice5()
    {
        foreach (char letter in name)
        {
            if (letter =='a')
            {
                thereIsAa = true;
            }
            if (!thereIsAa)
            {
                Debug.Log(letter);
            }
        }
    }

    private void Start()
    {
         exercice1();
         exercice2();
         exercice3();
         exercice4();
        exercice5();

    }


}
