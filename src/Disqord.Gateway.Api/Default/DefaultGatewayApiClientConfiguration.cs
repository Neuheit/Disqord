﻿using System;
using System.ComponentModel.DataAnnotations;
using Disqord.Gateway.Api.Models;

namespace Disqord.Gateway.Api.Default
{
    public class DefaultGatewayApiClientConfiguration
    {
        [Required]
        public virtual GatewayIntents Intents { get; set; } = GatewayIntents.Unprivileged;

        [Range(50, 250)]
        public virtual int LargeThreshold { get; set; } = 250;

        public virtual ShardId Id { get; set; } = ShardId.None;

        public virtual UpdatePresenceJsonModel Presence { get; set; }

        public DefaultGatewayApiClientConfiguration Clone()
        {
            var @this = (DefaultGatewayApiClientConfiguration) MemberwiseClone();
            // TODO: clone presence
            return @this;
        }
    }
}