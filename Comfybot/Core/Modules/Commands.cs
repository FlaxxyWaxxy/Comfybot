using Comfybot.Core.UserAccounts;
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comfybot.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        private readonly string imageFilePath = ("C:\\Users\\joeld\\source\\repos\\Comfybot\\Comfybot\\Images\\");

        [Command("cia")]
        public async Task ReplyMessageAsync1(string name)
        {
            await ReplyAsync($"{name} is a CIA nigger.");
            await Context.Channel.SendFileAsync(imageFilePath + "cia.jpg");
        }

        [Command("janny")]
        public async Task ReplyMessageAsync2()
        {
            await Context.Channel.SendFileAsync(imageFilePath + "janny.jpg");
        }

        [Command("hug")]
        public async Task ReplyMessageAsync3()
        {
            await Context.Channel.SendMessageAsync($"Hugs {Context.User.Mention}");
        }

        [Command("riddler")]
        public async Task ReplyMessageAsync4()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.AddField("Chaos?", "Fair!")
                .AddInlineField("Women?", "Whores!")
                .AddInlineField("Joker?", "Based!");

            await Context.Channel.SendMessageAsync("", false, builder.Build());
        }

        [Command("flax")]
        public async Task ReplyMessageAsync5()
        {
            await Context.Channel.SendFileAsync(imageFilePath + "flaxxy.png");
        }

        [Command("whatlevel")]
        public async Task WhatLevelIs(uint xp)
        {
            uint level = (uint)Math.Sqrt(xp / 50);
            await Context.Channel.SendMessageAsync("The ***comfy*** level is " + level);
        }

        [Command("level")]
        public async Task MyLevel()
        {
            var account = UserAccounts.GetAccount(Context.User);
            await Context.Channel.SendMessageAsync($"{Context.User.Mention} You have {account.XP} XP and you are level: {account.LevelNumber}");
        }

        [Command("addxp")]
        [RequireUserPermission(GuildPermission.Administrator)]
        public async Task AddXp(uint xp)
        {
            var account = UserAccounts.GetAccount(Context.User);
            await Context.Channel.SendMessageAsync($"{Context.User.Mention} You have {account.XP} XP and you are level: {account.LevelNumber}");
        }
    }
}

//Context.User; = Discord user
//Context.Client; = Discord entitity(user)
//Context.Guild; = Discord server
//Context.Message; = Message that triggered command
//await ReplyAsync($"{Context.Client.CurrentUser.Mention} || {Context.User.Mention} sent {Context.Message.Content} in {Context.Guild.Name}");