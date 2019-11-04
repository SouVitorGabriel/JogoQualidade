using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : StateMachineBehaviour {

    static float nu;
    // OnStateEnter is called before OnStateEnter is called on any state inside this state machine
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        nu = Random.Range(1, 5);
    }

    // OnStateUpdate is called before OnStateUpdate is called on any state inside this state machine
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {

        if (nu == 1)
        {
            animator.SetBool("trasTrue", false);
            animator.SetBool("esquerdaTrue", false);
            animator.SetBool("direitaTrue", false);
            animator.SetBool("frenteTrue", true);
        }

        if (nu == 2)
        {
            animator.SetBool("frenteTrue", false);
            animator.SetBool("esquerdaTrue", false);
            animator.SetBool("direitaTrue", false);
            animator.SetBool("trasTrue", true);
        }

        if (nu == 3)
        {
            animator.SetBool("frenteTrue", false);
            animator.SetBool("trasTrue", false);
            animator.SetBool("direitaTrue", false);
            animator.SetBool("esquerdaTrue", true);
        }

        if (nu == 4)
        {
            animator.SetBool("frenteTrue", false);
            animator.SetBool("trasTrue", false);
            animator.SetBool("esquerdaTrue", false);
            animator.SetBool("direitaTrue", true);
        }
    }



    // OnStateExit is called before OnStateExit is called on any state inside this state machine
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    
    }

    // OnStateMove is called before OnStateMove is called on any state inside this state machine
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateIK is called before OnStateIK is called on any state inside this state machine
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
    //
    //}

    // OnStateMachineEnter is called when entering a statemachine via its Entry Node
    //override public void OnStateMachineEnter(Animator animator, int stateMachinePathHash){
    //
    //}

    // OnStateMachineExit is called when exiting a statemachine via its Exit Node
    //override public void OnStateMachineExit(Animator animator, int stateMachinePathHash) {
    //
    //}
}
