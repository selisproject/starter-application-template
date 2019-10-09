// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).

using zAppDev.DotNet.Framework.Services;
using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace DemonstratorApp.BLL.ExternalRestServices
{
    public class PubSubRestService
    {
        public static string BaseUrl
        {
            get
            {
                var baseUrl = System.Configuration.ConfigurationManager.AppSettings["externalapis:PubSub:baseurl"];
                if (string.IsNullOrWhiteSpace(baseUrl))
                {
                    baseUrl = "https://94.70.243.21:20000";
                }
                if (!string.IsNullOrWhiteSpace(baseUrl) && !baseUrl.EndsWith("/"))
                {
                    baseUrl += "/";
                }
                return baseUrl;
            }
        }

        public static DemonstratorApp.ExternalStructs.PubSub.SubscriptionInfo Subscribe(DemonstratorApp.ExternalStructs.PubSub.SubscriptionRequest subscriptionrequest)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "subscribe";
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.POST,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "PubSub",
                Operation = "Subscribe",
                PostType = PostType.JSON,
                Data = subscriptionrequest, FormData = new Dictionary<string, object> {{"subscriptionrequest",subscriptionrequest}}
            };
            Func<ServiceConsumptionContainer, DemonstratorApp.ExternalStructs.PubSub.SubscriptionInfo> _invocation = (_httpResponse) =>
            {
                var _returnedItem = RestServiceConsumer.Consume<DemonstratorApp.ExternalStructs.PubSub.SubscriptionInfo>(_options, _httpResponse);
                return zAppDev.DotNet.Framework.Utilities.Common.SafeCast<DemonstratorApp.ExternalStructs.PubSub.SubscriptionInfo>(_returnedItem);
            };
            var _consumer = new ServiceConsumer<DemonstratorApp.ExternalStructs.PubSub.SubscriptionInfo>(_invocation);
            return _consumer.Invoke(_options);
        }
        public static void Unsubscribe(DemonstratorApp.ExternalStructs.PubSub.UnsubscribeRequest request)
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "unsubscribe";
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.POST,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "PubSub",
                Operation = "Unsubscribe",
                PostType = PostType.JSON,
                Data = request, FormData = new Dictionary<string, object> {{"request",request}}
            };
            Func<ServiceConsumptionContainer, object> _invocation = (_httpResponse) =>
            {
                RestServiceConsumer.Consume<object>(_options, _httpResponse);
                return null;
            };
            var _consumer = new ServiceConsumer<object>(_invocation);
            _consumer.Invoke(_options);
        }
        public static void Publish()
        {
            System.Func<string> getUrl = () =>
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
                return "";
            };
            var _operationRelativeUrl = getUrl.Invoke().Trim();
            if (_operationRelativeUrl?.StartsWith("/") == true && BaseUrl?.EndsWith("/") == true)
            {
                _operationRelativeUrl = _operationRelativeUrl.TrimStart('/');
            }
            var _targetUrl = BaseUrl + _operationRelativeUrl;
            var _options = new RestServiceConsumptionOptions
            {
                Url = _targetUrl,
                Verb = RestHTTPVerb.GET,
                ExtraHeaderData = new System.Collections.Generic.Dictionary<string, string>(StringComparer.OrdinalIgnoreCase) {   },
                LogAccess = false,
                IsCachingEnabled = false,
                ApiName = "PubSub",
                Operation = "Publish"
            };
            Func<ServiceConsumptionContainer, object> _invocation = (_httpResponse) =>
            {
                RestServiceConsumer.Consume<object>(_options, _httpResponse);
                return null;
            };
            var _consumer = new ServiceConsumer<object>(_invocation);
            _consumer.Invoke(_options);
        }

    }
}