using UnityEngine;

public class PlayerAttack : AttackAbstract
{
    private void Update(){
        ResetAttack();
    }
    public override void ResetAttack()
    {
        if(Input.GetMouseButtonDown(0)){
            base.ResetAttack();
        }
    }
}
