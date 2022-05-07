using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class TextAsset : MonoBehaviour
{
    [SerializeField]private DialogManager DialogManager;

    public GameObject[] numberOfLines;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("I've been waiting for you...", "Snail"));

        dialogTexts.Add(new DialogData("You have done a great job clearing the forest of demons so far. We knew we could count on you."));

        dialogTexts.Add(new DialogData("I have prepared a /color:magenta/little something /color:white/for your effort to save our forest."));

        dialogTexts.Add(new DialogData("Please accept this /color:red/Scroll of the Blood God/color:white/."));

        dialogTexts.Add(new DialogData("It increases your /color:magenta/damage /color:white/by one point."));

        dialogTexts.Add(new DialogData("Gracefully, from your friend, Fulbertus the snail."));

        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        numberOfLines[index].SetActive(true);
    }
}
