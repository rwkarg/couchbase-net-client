﻿using Couchbase.Core;
using Couchbase.Core.Transcoders;

namespace Couchbase.IO.Operations
{
    internal class GetK<T> : Get<T>
    {
        public GetK(string key, IVBucket vBucket, ITypeTranscoder transcoder, uint timeout)
            : base(key, vBucket, transcoder, timeout)
        {
        }

        protected GetK(string key, IVBucket vBucket, ITypeTranscoder transcoder, uint opaque, uint timeout)
            : base(key, vBucket, transcoder, opaque, timeout)
        {
        }

        public override OperationCode OperationCode
        {
            get { return OperationCode.GetK; }
        }

        public override IOperation Clone()
        {
            var cloned = new GetK<T>(Key, VBucket, Transcoder, Opaque, Timeout)
            {
                Attempts = Attempts,
                Cas = Cas,
                CreationTime = CreationTime
            };
            return cloned;
        }
    }
}
