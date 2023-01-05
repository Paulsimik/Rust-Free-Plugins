/*
 ########### README ####################################################
                                                                             
  !!! DON'T EDIT THIS FILE !!!
                                                                     
 ########### CHANGES ###################################################

 1.0.0
    - Plugin release

 #######################################################################
*/

using System.Collections.Generic;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core;
using Oxide.Game.Rust.Cui;
using System.Linq;
using UnityEngine;
using System;
using Oxide.Core.Plugins;
using Oxide.Core.Configuration;
using Rust;
using Network;
using CompanionServer;
using Newtonsoft.Json;
using System.Globalization;
using System.IO;
using ProtoBuf;
using System.Collections;
using Diag = System.Diagnostics;
using Oxide.Core.Libraries;
using WebSocketSharp;
using Oxide.Game.Rust.Libraries;
using VLB;

namespace Oxide.Plugins
{
    [Info("Projectile Trajectory ", "paulsimik", "1.0.0")]
    [Description("Plugin makes ddraw trajectories if player shooting")]
    class ProjectileTrajectory : RustPlugin
    {
        private bool DEBUG = true;

        #region [Fields]

        private const string fileName = "";
        private ulong chatIcon = 76561198976688507;

        private float duration = 5f;
        private float headSize = 0.1f;
        private Color color = Color.blue;

        #endregion

        #region [Oxide Hooks]

        private void Init()
        {
            //LoadData();
            //LoadConfig();
        }

        private void OnServerInitialized()
        {
        }

        private void Loaded()
        {
            Server.Broadcast($"{this.Name} by {this.Author} {this.Version} successfully loaded", chatIcon);
        }

        private void Unload()
        {
        }

        private void OnPlayerConnected(BasePlayer player)
        {

        }

        private void OnPlayerDisconnected(BasePlayer player)
        {

        }

        private void OnPlayerAttack(BasePlayer player, HitInfo info)
        {
            PrintDebug("attack");
            DrawProjectile(player, player.firedProjectiles[0].velocity, info.HitPositionWorld);
        }

        //private void OnWeaponFired(BaseProjectile projectile, BasePlayer player, ItemModProjectile mod, ProtoBuf.ProjectileShoot projectiles)
        //{
        //    var projectile2 = projectiles.projectiles[0];
        //    DrawProjectile(player, projectile2.startPos, (projectile2.startPos + projectile2.startVel.normalized * 450f));
        //}

        #endregion

        #region [Hooks]  

        private void DrawProjectile(BasePlayer player, Vector3 from, Vector3 to)
        {
            player.SendConsoleCommand("ddraw.arrow", duration, color, from, to, headSize);
            player.SendConsoleCommand("ddraw.sphere", duration, color, to, 0.2f);
        }

        #endregion

        #region [Chat Commands]

        //[ChatCommand("")]
        //private void cmd(BasePlayer player, string command, string[] args)
        //{
        //}

        #endregion

        #region [Console Commands]

        //[ConsoleCommand("")]
        //private void cmd(ConsoleSystem.Arg arg)
        //{
        //    BasePlayer player = arg.Player();
        //    if (player == null) return;
        //}

        #endregion

        #region [Classes]

        //private class Configuration
        //{
        //    [JsonProperty(PropertyName = "")]
        //}

        #endregion

        #region [Config]

        //private Configuration GetDefaultConfig()
        //{
        //    return new Configuration
        //    {

        //    };
        //}

        //protected override void LoadDefaultConfig()
        //{
        //    config = GetDefaultConfig();
        //    Puts("Generating new configuration file........");
        //}

        //protected override void SaveConfig() => Config.WriteObject(config);

        //protected override void LoadConfig()
        //{
        //    base.LoadConfig();

        //    try
        //    {
        //        config = Config.ReadObject<Configuration>();

        //        if (config == null)
        //        {
        //            LoadDefaultConfig();
        //        }
        //    }
        //    catch
        //    {
        //        PrintError("######### Configuration file is not valid! #########");
        //        return;
        //    }

        //    SaveConfig();
        //}

        #endregion

        #region [Localization]

        //private string GetLang(string key, string playerID, params object[] args) => string.Format(lang.GetMessage(key, this, playerID), args);

        //protected override void LoadDefaultMessages()
        //{
        //    lang.RegisterMessages(new Dictionary<string, string>
        //    {
        //        {"", ""},
        //        {"", ""}

        //    }, this);
        //}

        #endregion

        #region [Helpers]

        private void SendMessage(BasePlayer player, string msg) => Player.Message(player, msg, chatIcon);

        private void PrintDebug(object message)
        {
            if (!DEBUG)
                return;

            Debug.Log($"{this.Name} Debug: {message}");
        }

        #endregion
    }
}