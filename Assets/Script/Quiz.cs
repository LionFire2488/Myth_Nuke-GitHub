using UnityEngine;
using UnityEngine.UI;

public class Quiz : MonoBehaviour
{
    [System.Serializable]
    public class Question
    {
        public Sprite questionImage;   // รูปคำถาม
        public int correctAnswer;      // 0=A, 1=B, 2=C, 3=D
    }

    public Question[] questions;

    public Image quizImage;

    public GameObject correctPanel;
    public GameObject incorrectPanel;

    int currentQuestion = 0;

    void Start()
    {
        ShowQuestion();
    }

    void ShowQuestion()
    {
    if (currentQuestion >= questions.Length)
    {
        Debug.Log("No more questions");
        return;
    }

    quizImage.sprite = questions[currentQuestion].questionImage;

    correctPanel.SetActive(false);
    incorrectPanel.SetActive(false);
    }

    public void ChooseAnswer(int index)
    {
        if (index == questions[currentQuestion].correctAnswer)
        {
            correctPanel.SetActive(true);
        }
        else
        {
            incorrectPanel.SetActive(true);
        }
    }

    public void NextQuestion()
    {
        currentQuestion++;

        if (currentQuestion >= questions.Length)
        {
        Debug.Log("Quiz Finished!");
        return; // 🔴 หยุดก่อนเรียก ShowQuestion
        }

        ShowQuestion();
    }
}