using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
using TMPro;
public class BinaryQuestions : MonoBehaviour
{
    public TMP_Text questionText; 
    public GameObject yesButton; 
    public GameObject noButton; 

    [SerializeField] private Dictionary<string, bool> answers = new Dictionary<string, bool>(); 


    private string[] questions = {
        "Do you want to eat something Spicy or Sweet ?",
        "Do you want to go for asian or not asian ?",
        "Would you like to have any hot or cold drinks ?",
        
        

        
    };

    private int currentQuestionIndex = 0;

    void Start()
    {
        DisplayQuestion();
    }

    void DisplayQuestion()
    {
        if (currentQuestionIndex < questions.Length)
        {
           questionText.text  = questions[currentQuestionIndex];
        }
        else
        {
            GeneratePrompt();
        }
    }

    public void Answer(bool isYes)
    {
        string currentQuestion = questions[currentQuestionIndex];

        if (answers.ContainsKey(currentQuestion))
        {
            answers[currentQuestion] = isYes;
        }
        else
        {
            answers.Add(currentQuestion, isYes);
        }

        currentQuestionIndex++;
        DisplayQuestion();
    }

    void GeneratePrompt()
    {
        string prompt = "Please give me a food recipe that";
        bool hasNoAnswer = false;

        foreach (var answer in answers)
        {
            if (!answer.Value)
            {
                hasNoAnswer = true;
                prompt += " no " + answer.Key.Substring(7) + ",";
            }
            else
            {
                prompt += " " + answer.Key.Substring(7) + ",";
            }
        }

        if (!hasNoAnswer)
        {
            prompt += " has";
        }
        prompt = prompt.TrimEnd(',') + ".";

        Debug.Log(prompt);
    }

}
