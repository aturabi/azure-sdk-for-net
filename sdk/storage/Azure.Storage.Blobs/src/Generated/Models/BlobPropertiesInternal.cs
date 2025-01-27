// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Properties of a blob. </summary>
    internal partial class BlobPropertiesInternal
    {
        /// <summary> Initializes a new instance of BlobPropertiesInternal. </summary>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="etag"/> is null. </exception>
        internal BlobPropertiesInternal(DateTimeOffset lastModified, string etag)
        {
            if (etag == null)
            {
                throw new ArgumentNullException(nameof(etag));
            }

            LastModified = lastModified;
            Etag = etag;
        }

        /// <summary> Initializes a new instance of BlobPropertiesInternal. </summary>
        /// <param name="creationTime"></param>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="contentLength"> Size in bytes. </param>
        /// <param name="contentType"></param>
        /// <param name="contentEncoding"></param>
        /// <param name="contentLanguage"></param>
        /// <param name="contentMD5"></param>
        /// <param name="contentDisposition"></param>
        /// <param name="cacheControl"></param>
        /// <param name="blobSequenceNumber"></param>
        /// <param name="blobType"></param>
        /// <param name="leaseStatus"></param>
        /// <param name="leaseState"></param>
        /// <param name="leaseDuration"></param>
        /// <param name="copyId"></param>
        /// <param name="copyStatus"></param>
        /// <param name="copySource"></param>
        /// <param name="copyProgress"></param>
        /// <param name="copyCompletionTime"></param>
        /// <param name="copyStatusDescription"></param>
        /// <param name="serverEncrypted"></param>
        /// <param name="incrementalCopy"></param>
        /// <param name="destinationSnapshot"></param>
        /// <param name="deletedTime"></param>
        /// <param name="remainingRetentionDays"></param>
        /// <param name="accessTier"></param>
        /// <param name="accessTierInferred"></param>
        /// <param name="archiveStatus"></param>
        /// <param name="customerProvidedKeySha256"></param>
        /// <param name="encryptionScope"> The name of the encryption scope under which the blob is encrypted. </param>
        /// <param name="accessTierChangeTime"></param>
        /// <param name="tagCount"></param>
        /// <param name="expiresOn"></param>
        /// <param name="isSealed"></param>
        /// <param name="rehydratePriority"> If an object is in rehydrate pending state then this header is returned with priority of rehydrate. Valid values are High and Standard. </param>
        /// <param name="lastAccessedOn"></param>
        /// <param name="immutabilityPolicyExpiresOn"></param>
        /// <param name="immutabilityPolicyMode"></param>
        /// <param name="legalHold"></param>
        internal BlobPropertiesInternal(DateTimeOffset? creationTime, DateTimeOffset lastModified, string etag, long? contentLength, string contentType, string contentEncoding, string contentLanguage, byte[] contentMD5, string contentDisposition, string cacheControl, long? blobSequenceNumber, BlobType? blobType, LeaseStatus? leaseStatus, LeaseState? leaseState, LeaseDurationType? leaseDuration, string copyId, CopyStatus? copyStatus, string copySource, string copyProgress, DateTimeOffset? copyCompletionTime, string copyStatusDescription, bool? serverEncrypted, bool? incrementalCopy, string destinationSnapshot, DateTimeOffset? deletedTime, int? remainingRetentionDays, AccessTier? accessTier, bool? accessTierInferred, ArchiveStatus? archiveStatus, string customerProvidedKeySha256, string encryptionScope, DateTimeOffset? accessTierChangeTime, int? tagCount, DateTimeOffset? expiresOn, bool? isSealed, RehydratePriority? rehydratePriority, DateTimeOffset? lastAccessedOn, DateTimeOffset? immutabilityPolicyExpiresOn, BlobImmutabilityPolicyMode? immutabilityPolicyMode, bool? legalHold)
        {
            CreationTime = creationTime;
            LastModified = lastModified;
            Etag = etag;
            ContentLength = contentLength;
            ContentType = contentType;
            ContentEncoding = contentEncoding;
            ContentLanguage = contentLanguage;
            ContentMD5 = contentMD5;
            ContentDisposition = contentDisposition;
            CacheControl = cacheControl;
            BlobSequenceNumber = blobSequenceNumber;
            BlobType = blobType;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            CopyId = copyId;
            CopyStatus = copyStatus;
            CopySource = copySource;
            CopyProgress = copyProgress;
            CopyCompletionTime = copyCompletionTime;
            CopyStatusDescription = copyStatusDescription;
            ServerEncrypted = serverEncrypted;
            IncrementalCopy = incrementalCopy;
            DestinationSnapshot = destinationSnapshot;
            DeletedTime = deletedTime;
            RemainingRetentionDays = remainingRetentionDays;
            AccessTier = accessTier;
            AccessTierInferred = accessTierInferred;
            ArchiveStatus = archiveStatus;
            CustomerProvidedKeySha256 = customerProvidedKeySha256;
            EncryptionScope = encryptionScope;
            AccessTierChangeTime = accessTierChangeTime;
            TagCount = tagCount;
            ExpiresOn = expiresOn;
            IsSealed = isSealed;
            RehydratePriority = rehydratePriority;
            LastAccessedOn = lastAccessedOn;
            ImmutabilityPolicyExpiresOn = immutabilityPolicyExpiresOn;
            ImmutabilityPolicyMode = immutabilityPolicyMode;
            LegalHold = legalHold;
        }

        public DateTimeOffset? CreationTime { get; }
        public DateTimeOffset LastModified { get; }
        public string Etag { get; }
        /// <summary> Size in bytes. </summary>
        public long? ContentLength { get; }
        public string ContentType { get; }
        public string ContentEncoding { get; }
        public string ContentLanguage { get; }
        public byte[] ContentMD5 { get; }
        public string ContentDisposition { get; }
        public string CacheControl { get; }
        public long? BlobSequenceNumber { get; }
        public BlobType? BlobType { get; }
        public LeaseStatus? LeaseStatus { get; }
        public LeaseState? LeaseState { get; }
        public LeaseDurationType? LeaseDuration { get; }
        public string CopyId { get; }
        public CopyStatus? CopyStatus { get; }
        public string CopySource { get; }
        public string CopyProgress { get; }
        public DateTimeOffset? CopyCompletionTime { get; }
        public string CopyStatusDescription { get; }
        public bool? ServerEncrypted { get; }
        public bool? IncrementalCopy { get; }
        public string DestinationSnapshot { get; }
        public DateTimeOffset? DeletedTime { get; }
        public int? RemainingRetentionDays { get; }
        public AccessTier? AccessTier { get; }
        public bool? AccessTierInferred { get; }
        public ArchiveStatus? ArchiveStatus { get; }
        public string CustomerProvidedKeySha256 { get; }
        /// <summary> The name of the encryption scope under which the blob is encrypted. </summary>
        public string EncryptionScope { get; }
        public DateTimeOffset? AccessTierChangeTime { get; }
        public int? TagCount { get; }
        public DateTimeOffset? ExpiresOn { get; }
        public bool? IsSealed { get; }
        /// <summary> If an object is in rehydrate pending state then this header is returned with priority of rehydrate. Valid values are High and Standard. </summary>
        public RehydratePriority? RehydratePriority { get; }
        public DateTimeOffset? LastAccessedOn { get; }
        public DateTimeOffset? ImmutabilityPolicyExpiresOn { get; }
        public BlobImmutabilityPolicyMode? ImmutabilityPolicyMode { get; }
        public bool? LegalHold { get; }
    }
}
