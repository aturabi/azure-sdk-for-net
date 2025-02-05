// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed file item. </summary>
    internal partial class FileItem
    {
        /// <summary> Initializes a new instance of FileItem. </summary>
        /// <param name="name"></param>
        /// <param name="properties"> File properties. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="properties"/> is null. </exception>
        internal FileItem(string name, FileProperty properties)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Name = name;
            Properties = properties;
        }

        /// <summary> Initializes a new instance of FileItem. </summary>
        /// <param name="name"></param>
        /// <param name="fileId"></param>
        /// <param name="properties"> File properties. </param>
        /// <param name="attributes"></param>
        /// <param name="permissionKey"></param>
        internal FileItem(string name, string fileId, FileProperty properties, string attributes, string permissionKey)
        {
            Name = name;
            FileId = fileId;
            Properties = properties;
            Attributes = attributes;
            PermissionKey = permissionKey;
        }

        public string Name { get; }
        public string FileId { get; }
        /// <summary> File properties. </summary>
        public FileProperty Properties { get; }
        public string Attributes { get; }
        public string PermissionKey { get; }
    }
}
