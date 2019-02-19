﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Data;

public class FightResultPanel : Panel
{
    public Button againButton;
    public Button exitButton;
    public GameObject victoryObj;
    public GameObject loseObj;

    protected override void OnInit()
    {
        againButton.onClick.AddListener(OnAgainClick);
        exitButton.onClick.AddListener(OnExitClick);
    }

    protected override void OnShow(params object[] args)
    {
        var isVictory = (bool)args[0];

        victoryObj.SetActive(isVictory);
        loseObj.SetActive(!isVictory);
    }

    void OnAgainClick()
    {
        var worldMgr = WorldManager.Instance;
        var battleData = worldMgr.GameCore.GetData<BattleData>();
        battleData.battleInitialize.StartBattle();

        var uiMgr = worldMgr.UIMgr;
        uiMgr.ShowPanel(PanelType.FightPanel);
        uiMgr.HidePanel(PanelType);
    }

    void OnExitClick()
    {
        var worldMgr = WorldManager.Instance;

        var objDataList = worldMgr.ObjectDataList;
        for (var i = 0; i < objDataList.Count;)
        {
            var objData = objDataList[i];
            var resourceData = objData.GetData<ResourceData>();
            if (resourceData != null)
            {
                Module.ResourceLoader.DestroyResource(objData);
            }
            else
            {
                i++;
            }
        }

        var battleData = worldMgr.GameCore.GetData<BattleData>();
        Destroy(battleData.battleInitialize.gameObject);
        battleData.battleInitialize = null;

        worldMgr.PoolMgr.Clear();

        System.GC.Collect();

        var uiMgr = worldMgr.UIMgr;
        uiMgr.ShowPanel(PanelType.MainPanel);
        uiMgr.HidePanel(PanelType);
    }
}
