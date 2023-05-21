// <copyright file = " <File Name>.cs" company = "Terry D.Eppler">
// Copyright (c) Terry Eppler.All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Net;
    using System.Net.Mail;
    using System.Net.Mime;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading;
    using Microsoft.Office.Interop.Outlook;
    using Attachment = System.Net.Mail.Attachment;
    using Exception = System.Exception;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeDefaultValueWhenTypeNotEvident" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    public class OutlookManager
    {
        /// <summary> Gets or sets the name of the host. </summary>
        /// <value> The name of the host. </value>
        public string HostName { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/>
        /// class.
        /// </summary>
        public OutlookManager( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="OutlookManager"/>
        /// class.
        /// </summary>
        /// <param name="hostName"> Name of the host. </param>
        public OutlookManager( string hostName )
        {
            HostName = hostName;
        }

        /// <summary> Sends the mail. </summary>
        /// <param name="config"> The configuration. </param>
        /// <param name="content"> The content. </param>
        public void SendMail( OutlookConfig config, EmailContent content )
        {
            if( config != null
               && content != null )
            {
                try
                {
                    var _message = CreateMessage( config, content );
                    Send( _message, config );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        private void ReadInboxItems( )
        {
            Application _outlook = null;
            NameSpace _namespace = null;
            MAPIFolder _inbox = null;
            Items _items = null;
            try
            {
                _outlook = new Application( );
                _namespace = _outlook.GetNamespace( "MAPI" );
                _inbox = _namespace.GetDefaultFolder( OlDefaultFolders.olFolderInbox );
                _items = _inbox.Items;
                foreach ( MailItem item in _items )
                {
                    var stringBuilder = new StringBuilder( );
                    stringBuilder.AppendLine( "From: " + item.SenderEmailAddress );
                    stringBuilder.AppendLine( "To: " + item.To );
                    stringBuilder.AppendLine( "CC: " + item.CC );
                    stringBuilder.AppendLine( "" );
                    stringBuilder.AppendLine( "Subject: " + item.Subject );
                    stringBuilder.AppendLine( item.Body );
                    Marshal.ReleaseComObject( item );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
            finally
            {
                ReleaseComObject( _items );
                ReleaseComObject( _inbox );
                ReleaseComObject( _namespace );
                ReleaseComObject( _outlook );
            }
        }

        /// <summary> Constructs the email message. </summary>
        /// <param name="config"> The configuration. </param>
        /// <param name="content"> The content. </param>
        /// <returns> </returns>
        private MailMessage CreateMessage( OutlookConfig config, EmailContent content )
        {
            if( config != null
               && content != null )
            {
                try
                {
                    var _message = new MailMessage( );
                    for( var j = 0; j < config.TOs.Length; j++ )
                    {
                        var to = config.TOs[ j ];
                        if( !string.IsNullOrEmpty( to ) )
                        {
                            _message.To.Add( to );
                        }
                    }

                    for( var i = 0; i < config.CCs.Length; i++ )
                    {
                        var _cc = config.CCs[ i ];
                        if( !string.IsNullOrEmpty( _cc ) )
                        {
                            _message.CC.Add( _cc );
                        }
                    }

                    _message.From = new MailAddress( config.From, config.DisplayName, Encoding.UTF8 );
                    _message.IsBodyHtml = content.IsHtml;
                    _message.Body = content.Content;
                    _message.Priority = config.Priority;
                    _message.Subject = config.Subject;
                    _message.BodyEncoding = Encoding.UTF8;
                    _message.SubjectEncoding = Encoding.UTF8;
                    if( content.AttachFileName != null )
                    {
                        var _data = new Attachment( content.AttachFileName, MediaTypeNames.Application.Zip );
                        _message.Attachments.Add( _data );
                    }

                    return _message;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( MailMessage );
                }
            }

            return default( MailMessage );
        }

        /// <summary> Sends the specified message. </summary>
        /// <param name="message"> The message. </param>
        /// <param name="config"> The configuration. </param>
        private void Send( MailMessage message, OutlookConfig config )
        {
            if( message != null
               && config != null )
            {
                try
                {
                    var _client = new SmtpClient( );
                    _client.UseDefaultCredentials = false;
                    _client.Credentials = new NetworkCredential( config.UserName, config.Password );
                    _client.Host = HostName;
                    _client.Port = 25;
                    _client.EnableSsl = true;
                    _client.Send( message );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    message.Dispose( );
                }
            }
        }

        private static void ReleaseComObject( object obj )
        {
            if ( obj != null )
            {
                Marshal.ReleaseComObject( obj );
                obj = null;
            }
        }

        /// <summary> Get ErrorDialog Dialog. </summary>
        /// <param name="ex"> The ex. </param>
        private protected void Fail( Exception ex )
        {
            using var _error = new ErrorDialog( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}