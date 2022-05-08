using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Doublsb.Dialog;

public class EaDialog : MonoBehaviour
{
    public DialogManager DialogManager;

    public GameObject[] numberOfLines;

    private void Awake()
    {
        var dialogTexts = new List<DialogData>();

        dialogTexts.Add(new DialogData("Go Away!", "TheFrog"));

        dialogTexts.Add(new DialogData("You are too poor. Go earn some money!"));


        DialogManager.Show(dialogTexts);
    }

    private void Show_Example(int index)
    {
        numberOfLines[index].SetActive(true);
    }
}
