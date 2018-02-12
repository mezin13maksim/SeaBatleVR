using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class shot_script_Rain : RAINAction
{
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
        GameObject.Find("Cannon").GetComponentInChildren<shot_script>().Shoot();
        GameObject.Find("Cannon (1)").GetComponentInChildren<shot_script>().Shoot();
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        return ActionResult.SUCCESS;
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }
}