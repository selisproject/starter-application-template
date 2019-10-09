// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DemonstratorApp.BO;
using DemonstratorApp.UI.Controllers.Unauthorized;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DemonstratorApp.UI.ViewModels.MasterPageSignIn;
using DemonstratorApp.UI.Controllers.MasterPageSignIn;
namespace DemonstratorApp.UI.ViewModels.Unauthorized
{
    public class UnauthorizedViewModel : MasterPageSignInViewModel
    {


        public UnauthorizedViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel))]
    public class UnauthorizedViewModelDTO : MasterPageSignInViewModelDTO, IViewModelDTO<DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel>
    {

        [JsonConstructor]
        public UnauthorizedViewModelDTO() { }
        public UnauthorizedViewModelDTO(DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
        }
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel).FullName;

        public new DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel();
        }
        new  public DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DemonstratorApp.UI.ViewModels.Unauthorized.UnauthorizedViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
        }
    }



}
