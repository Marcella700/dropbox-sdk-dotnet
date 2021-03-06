// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The trusted teams request action object</para>
    /// </summary>
    public class TrustedTeamsRequestAction
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<TrustedTeamsRequestAction> Encoder = new TrustedTeamsRequestActionEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<TrustedTeamsRequestAction> Decoder = new TrustedTeamsRequestActionDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="TrustedTeamsRequestAction" />
        /// class.</para>
        /// </summary>
        public TrustedTeamsRequestAction()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Invited</para>
        /// </summary>
        public bool IsInvited
        {
            get
            {
                return this is Invited;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Invited, or <c>null</c>.</para>
        /// </summary>
        public Invited AsInvited
        {
            get
            {
                return this as Invited;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Expired</para>
        /// </summary>
        public bool IsExpired
        {
            get
            {
                return this is Expired;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Expired, or <c>null</c>.</para>
        /// </summary>
        public Expired AsExpired
        {
            get
            {
                return this as Expired;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Revoked</para>
        /// </summary>
        public bool IsRevoked
        {
            get
            {
                return this is Revoked;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Revoked, or <c>null</c>.</para>
        /// </summary>
        public Revoked AsRevoked
        {
            get
            {
                return this as Revoked;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Accepted</para>
        /// </summary>
        public bool IsAccepted
        {
            get
            {
                return this is Accepted;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Accepted, or <c>null</c>.</para>
        /// </summary>
        public Accepted AsAccepted
        {
            get
            {
                return this as Accepted;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Declined</para>
        /// </summary>
        public bool IsDeclined
        {
            get
            {
                return this is Declined;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Declined, or <c>null</c>.</para>
        /// </summary>
        public Declined AsDeclined
        {
            get
            {
                return this as Declined;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="TrustedTeamsRequestAction" />.</para>
        /// </summary>
        private class TrustedTeamsRequestActionEncoder : enc.StructEncoder<TrustedTeamsRequestAction>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(TrustedTeamsRequestAction value, enc.IJsonWriter writer)
            {
                if (value is Invited)
                {
                    WriteProperty(".tag", "invited", writer, enc.StringEncoder.Instance);
                    Invited.Encoder.EncodeFields((Invited)value, writer);
                    return;
                }
                if (value is Expired)
                {
                    WriteProperty(".tag", "expired", writer, enc.StringEncoder.Instance);
                    Expired.Encoder.EncodeFields((Expired)value, writer);
                    return;
                }
                if (value is Revoked)
                {
                    WriteProperty(".tag", "revoked", writer, enc.StringEncoder.Instance);
                    Revoked.Encoder.EncodeFields((Revoked)value, writer);
                    return;
                }
                if (value is Accepted)
                {
                    WriteProperty(".tag", "accepted", writer, enc.StringEncoder.Instance);
                    Accepted.Encoder.EncodeFields((Accepted)value, writer);
                    return;
                }
                if (value is Declined)
                {
                    WriteProperty(".tag", "declined", writer, enc.StringEncoder.Instance);
                    Declined.Encoder.EncodeFields((Declined)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="TrustedTeamsRequestAction" />.</para>
        /// </summary>
        private class TrustedTeamsRequestActionDecoder : enc.UnionDecoder<TrustedTeamsRequestAction>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="TrustedTeamsRequestAction"
            /// />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override TrustedTeamsRequestAction Create()
            {
                return new TrustedTeamsRequestAction();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override TrustedTeamsRequestAction Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "invited":
                        return Invited.Decoder.DecodeFields(reader);
                    case "expired":
                        return Expired.Decoder.DecodeFields(reader);
                    case "revoked":
                        return Revoked.Decoder.DecodeFields(reader);
                    case "accepted":
                        return Accepted.Decoder.DecodeFields(reader);
                    case "declined":
                        return Declined.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The invited object</para>
        /// </summary>
        public sealed class Invited : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Invited> Encoder = new InvitedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Invited> Decoder = new InvitedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Invited" /> class.</para>
            /// </summary>
            private Invited()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Invited</para>
            /// </summary>
            public static readonly Invited Instance = new Invited();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedEncoder : enc.StructEncoder<Invited>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Invited value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Invited" />.</para>
            /// </summary>
            private class InvitedDecoder : enc.StructDecoder<Invited>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Invited" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Invited Create()
                {
                    return Invited.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The expired object</para>
        /// </summary>
        public sealed class Expired : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Expired> Encoder = new ExpiredEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Expired> Decoder = new ExpiredDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Expired" /> class.</para>
            /// </summary>
            private Expired()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Expired</para>
            /// </summary>
            public static readonly Expired Instance = new Expired();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Expired" />.</para>
            /// </summary>
            private class ExpiredEncoder : enc.StructEncoder<Expired>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Expired value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Expired" />.</para>
            /// </summary>
            private class ExpiredDecoder : enc.StructDecoder<Expired>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Expired" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Expired Create()
                {
                    return Expired.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The revoked object</para>
        /// </summary>
        public sealed class Revoked : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Revoked> Encoder = new RevokedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Revoked> Decoder = new RevokedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Revoked" /> class.</para>
            /// </summary>
            private Revoked()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Revoked</para>
            /// </summary>
            public static readonly Revoked Instance = new Revoked();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Revoked" />.</para>
            /// </summary>
            private class RevokedEncoder : enc.StructEncoder<Revoked>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Revoked value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Revoked" />.</para>
            /// </summary>
            private class RevokedDecoder : enc.StructDecoder<Revoked>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Revoked" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Revoked Create()
                {
                    return Revoked.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The accepted object</para>
        /// </summary>
        public sealed class Accepted : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Accepted> Encoder = new AcceptedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Accepted> Decoder = new AcceptedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Accepted" /> class.</para>
            /// </summary>
            private Accepted()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Accepted</para>
            /// </summary>
            public static readonly Accepted Instance = new Accepted();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Accepted" />.</para>
            /// </summary>
            private class AcceptedEncoder : enc.StructEncoder<Accepted>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Accepted value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Accepted" />.</para>
            /// </summary>
            private class AcceptedDecoder : enc.StructDecoder<Accepted>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Accepted" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Accepted Create()
                {
                    return Accepted.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The declined object</para>
        /// </summary>
        public sealed class Declined : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Declined> Encoder = new DeclinedEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Declined> Decoder = new DeclinedDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Declined" /> class.</para>
            /// </summary>
            private Declined()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Declined</para>
            /// </summary>
            public static readonly Declined Instance = new Declined();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Declined" />.</para>
            /// </summary>
            private class DeclinedEncoder : enc.StructEncoder<Declined>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Declined value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Declined" />.</para>
            /// </summary>
            private class DeclinedDecoder : enc.StructDecoder<Declined>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Declined" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Declined Create()
                {
                    return Declined.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : TrustedTeamsRequestAction
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
