// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DemonstratorApp.BO;
using DemonstratorApp.UI.Controllers.CreateAdmin;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DemonstratorApp.UI.ViewModels.MasterPageSignIn;
using DemonstratorApp.UI.Controllers.MasterPageSignIn;
namespace DemonstratorApp.UI.ViewModels.CreateAdmin
{
    public class CreateAdminViewModel : MasterPageSignInViewModel
    {
        public string username;
        public string password;
        public string repeatPassword;


        public CreateAdminViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel))]
    public class CreateAdminViewModelDTO : MasterPageSignInViewModelDTO, IViewModelDTO<DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel>
    {

        [JsonConstructor]
        public CreateAdminViewModelDTO() { }
        public CreateAdminViewModelDTO(DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            username = original.username;
            password = original.password;
            repeatPassword = original.repeatPassword;
        }
        public string username;
        public string password;
        public string repeatPassword;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel).FullName;

        public new DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel();
        }
        new  public DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DemonstratorApp.UI.ViewModels.CreateAdmin.CreateAdminViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.username = username;
            original.password = password;
            original.repeatPassword = repeatPassword;
        }
    }



}
