﻿using Disqord.Models;

namespace Disqord
{
    public class MessageSticker : IIdentifiable, INamable
    {
        public Snowflake Id { get; }

        public string Name { get; }

        public StickerFormatType FormatType { get; }

        public MessageSticker(StickerJsonModel model)
        {
            Id = model.Id;
            Name = model.Name;
            FormatType = model.FormatType;
        }

        public override string ToString()
            => $"Sticker {Name} ({Id})";
    }
}
