﻿using Hi3Helper.Sophon.Infos;

// ReSharper disable IdentifierTypo
// ReSharper disable StringLiteralTypo
// ReSharper disable CommentTypo
namespace Hi3Helper.Sophon.Infos
{
    public struct SophonChunksInfo
    {
        public string ChunksBaseUrl;
        public int    ChunksCount;
        public int    FilesCount;
        public long   TotalSize;
        public long   TotalCompressedSize;
        public bool   IsUseCompression;
    }
}

namespace Hi3Helper.Sophon
{
    public static partial class SophonManifest
    {
        /// <summary>
        ///     Create Sophon chunk information. Please refer the API response to set the argument value.
        /// </summary>
        /// <param name="chunksBaseUrl">
        ///     The base URL for the chunks. To find the value, See the API section called: <c>chunk_download</c> ->
        ///     <c>url_prefix</c>
        /// </param>
        /// <param name="chunksCount">
        ///     The count of chunks to be downloaded. To find the value, See the API section called: <c>stats</c> ->
        ///     <c>chunk_count</c>
        /// </param>
        /// <param name="filesCount">
        ///     The count of files to be downloaded. To find the value, See the API section called: <c>stats</c> ->
        ///     <c>file_count</c>
        /// </param>
        /// <param name="isUseCompression">
        ///     Determine the use of compression within the chunks. To find the value, See the API section called:
        ///     <c>chunk_download</c> -> <c>compression</c>
        /// </param>
        /// <param name="totalSize">
        ///     Total decompressed size of files to be downloaded. To find the value, See the API section called: <c>stats</c> ->
        ///     <c>uncompressed_size</c>
        /// </param>
        /// <param name="totalCompressedSize">
        ///     Total compressed size of files to be downloaded. To find the value, See the API section called: <c>stats</c> ->
        ///     <c>compressed_size</c>
        /// </param>
        /// <returns>Sophon Chunks Information struct</returns>
        public static SophonChunksInfo CreateChunksInfo(string chunksBaseUrl,
                                                        int    chunksCount,
                                                        int    filesCount,
                                                        bool   isUseCompression,
                                                        long   totalSize,
                                                        long   totalCompressedSize = 0)
        {
            return new SophonChunksInfo
            {
                ChunksBaseUrl       = chunksBaseUrl,
                ChunksCount         = chunksCount,
                FilesCount          = filesCount,
                IsUseCompression    = isUseCompression,
                TotalSize           = totalSize,
                TotalCompressedSize = totalCompressedSize
            };
        }
    }
}