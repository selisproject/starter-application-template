// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using DemonstratorApp.BO;
using DemonstratorApp.UI.Controllers.MasterPageForSlide;
using AppCode;
using zAppDev.DotNet.Framework.Data;
using zAppDev.DotNet.Framework.Utilities;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Mvc;
using System.ComponentModel.DataAnnotations;
namespace DemonstratorApp.UI.ViewModels.MasterPageForSlide
{
    public class MasterPageForSlideViewModel
    {
        public string Title;


        public MasterPageForSlideViewModel()
        {
        }


        public virtual void Evict()
        {
            var manager = MiniSessionManager.Instance;
        }

    }


    [OriginalType(typeof(DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel))]
    public class MasterPageForSlideViewModelDTO : ViewModelDTOBase, IViewModelDTO<DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel>
    {

        [JsonConstructor]
        public MasterPageForSlideViewModelDTO() { }
        public MasterPageForSlideViewModelDTO(DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel original, bool parentIsDirty = false)
        {
            if (original == null) return;
            _runtimeType = original.GetType().FullName;
            Title = original.Title;
        }
        public string Title;
        public  string _runtimeType
        {
            get;
            set;
        }
        public override string _originalTypeClassName => typeof(DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel).FullName;

        public DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel GetModel()
        {
            var alreadySeenInstance = DTOHelper.GetSeenModelInstance<DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel>(_clientKey, _originalTypeClassName, _baseClasses);
            if (alreadySeenInstance != null) return alreadySeenInstance;
            return new DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel();
        }
        public DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel Convert()
        {
            var original = GetModel();
            if (original == null)
            {
                original = new DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel();
            }
            DTOHelper.UpdateSeenModelInstances(this, original);
            Hydrate(original);
            return original;
        }
        public void Hydrate(DemonstratorApp.UI.ViewModels.MasterPageForSlide.MasterPageForSlideViewModel original)
        {
            if (original == null) return;
            original.Title = Title;
        }
    }



}
