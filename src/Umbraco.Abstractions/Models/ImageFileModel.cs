﻿namespace Umbraco.Core.Models
{
    public class ImageFileModel
    {
        public byte[] Data { get; }
        public string MimeType { get; }

        public ImageFileModel(byte[] imageData, string mimeType)
        {
            Data = imageData;
            MimeType = mimeType;
        }
    }
}