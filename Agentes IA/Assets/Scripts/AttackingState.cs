using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackingState : FunctionsFSM
{
    public override void EnterState(AgenteEstatico agent)
    {
        //Código para cuando entra al estado de atacar
        Debug.Lag("Estado de atacar")
        agent.agentStatus = AgentState.Attacking;

        agent.Firebullet();
    }

    public override void UpdateState(AgenteEstatico agent)
    {
        //Código para cuando no se detecta al jugador
    }
}
