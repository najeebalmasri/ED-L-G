using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerTF : MonoBehaviour
{
    public QuestionTF[] questions;

    private static List<QuestionTF> unansweredQuestions;
    private QuestionTF currentQuestion;

    [SerializeField]
    private Text factText;

    [SerializeField]
    private Text trueAnswerText;

    [SerializeField]
    private Text falseAnswerText;

    [SerializeField]
    private Animator animator;

    [SerializeField]
    private float timeBetweenQuestions = 1f;
   
    void Start()
    {
        if (unansweredQuestions == null || unansweredQuestions.Count == 0)
        {
            unansweredQuestions = questions.ToList<QuestionTF>();
        }

        setCurrentQuestion();
        //Debug.Log(currentQuestion.fact + "is" + currentQuestion.isTrue);
    }

    void setCurrentQuestion()
    {
        int randomQuestionIndex = Random.Range(0, unansweredQuestions.Count);
        currentQuestion = unansweredQuestions[randomQuestionIndex];

        factText.text = currentQuestion.fact;

        if (currentQuestion.isTrue)
        {
            trueAnswerText.text = "CORRECT";
            falseAnswerText.text = "WRONG";
        }
        else
        {
            trueAnswerText.text = "WRONG";
            falseAnswerText.text = "CORRECT";
        }
    }

    IEnumerator transitionToNextQuestion()
    {
        unansweredQuestions.Remove(currentQuestion);

        yield return new WaitForSeconds(timeBetweenQuestions);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void UserSelectTrue()
    {
        animator.SetTrigger("True");

        if (currentQuestion.isTrue)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }

        StartCoroutine(transitionToNextQuestion());
    }

    public void UserSelectFalse()
    {
        animator.SetTrigger("False");

        if (!currentQuestion.isTrue)
        {
            Debug.Log("CORRECT");
        }
        else
        {
            Debug.Log("WRONG");
        }

        StartCoroutine(transitionToNextQuestion());
    }
}
