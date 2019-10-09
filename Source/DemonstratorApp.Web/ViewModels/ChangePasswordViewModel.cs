// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DemonstratorApp.BO;
using DemonstratorApp.UI.Controllers.ChangePassword;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
using DemonstratorApp.UI.ViewModels.MasterPage;
using DemonstratorApp.UI.Controllers.MasterPage;
namespace DemonstratorApp.UI.ViewModels.ChangePassword
{
    public class ChangePasswordViewModel : MasterPageViewModel
    {
        public string txtCurrent;
        public string txtNew;
        public string txtNewRepeat;


        public ChangePasswordViewModel()
        {
        }


        public override void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel))]
    public class ChangePasswordViewModelDTO : MasterPageViewModelDTO, IViewModelDTO<DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel>
    {

        [JsonConstructor]
        public ChangePasswordViewModelDTO() { }
        public ChangePasswordViewModelDTO(DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel original, bool parentIsDirty = false)  : base(original)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            txtCurrent = original.txtCurrent;
            txtNew = original.txtNew;
            txtNewRepeat = original.txtNewRepeat;
        }
        public string txtCurrent;
        public string txtNew;
        public string txtNewRepeat;
        public new string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel).FullName;

        public new DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel();
        }
        new  public DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DemonstratorApp.UI.ViewModels.ChangePassword.ChangePasswordViewModel original)
        {
            if (original == null) return;
            base.Hydrate(original);
            original.txtCurrent = txtCurrent;
            original.txtNew = txtNew;
            original.txtNewRepeat = txtNewRepeat;
        }
    }



}
