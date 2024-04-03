using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    // variables for sum
    public float value_1;
    public float value_2;
    [HideInInspector] public float result_sum;

    // variables for deduction
    public float value_3;
    public float value_4;
    [HideInInspector] public float result_ded;

    // variables for multiplication
    public float value_5;
    public float value_6;
    [HideInInspector] public float result_mult;

    // variables for splitting
    public float value_7;
    public float value_8;
    [HideInInspector] public float result_split;

    // Start is called before the first frame update
    void Start()
    {
        Sum(); Ded(); Mult(); Split();
    }

    //Summary
    public void Sum()
    {
        result_sum = value_1 + value_2;
        Debug.Log($"{value_1} + {value_2} = {result_sum}");
    }

    //Deduction
    public void Ded()
    {
        result_ded = value_3 - value_4;
        Debug.Log($"{value_3} - {value_4} = {result_ded}");
    }
    //Miltiplication
    public void Mult()
    {
        result_mult = value_5 * value_6;
        Debug.Log($"{value_5} * {value_6} = {result_mult}");
    }
    //Splitting
    public void Split()
    {
        result_split = value_7 / value_8;
        Debug.Log($"{value_7} / {value_8} = {result_split}");
    }
}
