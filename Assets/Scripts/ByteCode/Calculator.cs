using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Calculator : MonoBehaviour
{
    public NumberExpression firstNumber;
    public NumberExpression secondNumber;
    public CalculationType calculation;

    [Header("Operation Expressions")]
    [SerializeField] private AdditionExpression addition;
    [SerializeField] private SubtractionExpression subtraction;
    [SerializeField] private MultiplicationExpression multiplication;
    [SerializeField] private DivisionExpression division;

    [Header("Result Display")]
    [SerializeField] private Text uIText;

    private double DoCalculation()
    {
        switch (calculation)
        {
            case (CalculationType)0xA:
                addition.leftOperand = firstNumber.Evaluate();
                addition.rightOperand = secondNumber.Evaluate();
                return addition.Evaluate();

            case (CalculationType)0xB:
                subtraction.leftOperand = firstNumber.Evaluate();
                subtraction.rightOperand = secondNumber.Evaluate();
                return subtraction.Evaluate();

            case (CalculationType)0xC:
                multiplication.leftOperand = firstNumber.Evaluate();
                multiplication.rightOperand = secondNumber.Evaluate();
                return multiplication.Evaluate();

            case (CalculationType)0xD:
                division.leftOperand = firstNumber.Evaluate();
                division.rightOperand = secondNumber.Evaluate();
                return division.Evaluate();

            default:
                return 0;
        }
    }

    public void PrintResult()
    {
        uIText.text = (string.Format("The {0} result is {1}", calculation, DoCalculation()));
    }
}
public enum CalculationType { addition = 0xA, subtraction = 0xB, multiplication = 0xC, division = 0xD };

