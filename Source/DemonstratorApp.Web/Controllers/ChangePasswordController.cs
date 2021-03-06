// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
using AppCode;
using DemonstratorApp.BO;
using DemonstratorApp.UI.ViewModels.ChangePassword;
using Identity = zAppDev.DotNet.Framework.Identity;
using log4net;
using Newtonsoft.Json;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using zAppDev.DotNet.Framework.Configuration;
using zAppDev.DotNet.Framework.Data.Domain;
using zAppDev.DotNet.Framework.Identity;
using zAppDev.DotNet.Framework.Identity.Model;
using zAppDev.DotNet.Framework.Linq;
using zAppDev.DotNet.Framework.Mvc;
using zAppDev.DotNet.Framework.Utilities;

namespace DemonstratorApp.UI.Controllers.ChangePassword
{

    [RoutePrefix("ChangePassword")]
    public class ChangePasswordController : ControllerBase<ChangePasswordViewModel, ChangePasswordViewModelDTO>
    {

        /*<Form:ChangePassword:0/>*/
        public ChangePasswordController()
        {
            _logger = log4net.LogManager.GetLogger(typeof(ChangePasswordController));
            if (ViewModelDTOBase.DTOHelper == null)
            {
                ViewModelDTOBase.DTOHelper = new DTOHelper();
            }
        }

        protected override void ViewModelLoaded()
        {
            var masterViewModel = new DemonstratorApp.UI.ViewModels.MasterPage.MasterPageViewModel
            {
                Title = model.Title
            };
            _parentController = new MasterPage.MasterPageController(masterViewModel);
            _parentController.IsDirty = IsDirty;
        }

        public void SetModel(ChangePasswordViewModel m)
        {
            @model = m;
        }


        public override void CommitAllFiles()
        {
        }

        public override void CommitAllFilesLegacy()
        {
        }

        public override void ClearPendingFiles()
        {
        }






        [HttpGet]

        [Route("GetViewDTO")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ContentResult GetViewDTO(int hash)
        {
            return Content(GetViewFromViewDTOsDicSerialized(hash));
        }

        [HttpPost]

        [Route("UpdateInstance")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult UpdateInstance()
        {
            return PrepareUpdateInstanceResult(typeof(ChangePasswordViewModel));
        }

        [HttpPost]

        [Route("_Raise")]
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName = "GeneralOperation", ClaimType = ClaimTypes.GenericAction)]
        public ActionResult _Raise()
        {
            return _RaiseEvent();
        }


        [HttpGet]
        [Route("DownloadFileByPath")]
        [CustomControllerActionFilter(HasDefaultResultView=true)]
        public FileContentResult DownloadFileByPath(string path, string defaultPath = null)
        {
            if (IdentityHelper.GetCurrentIdentityUser() == null) return null;
            if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(defaultPath))
            {
                throw new ApplicationException("Please provide a path.");
            }
            return FileHelper.PendingDownloadInstance.DownloadByPath(path, defaultPath);
        }




        #region Controller Actions
        [CustomControllerActionFilter(HasDefaultResultView=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("Render")]
        public ActionResult Render()

        {
            @model = new ChangePasswordViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ChangePassword"] = "Render";
            return null;
        }

        [CustomControllerActionFilter(FillDropDownInitialValues=true, ActionName="Render", ClaimType = ClaimTypes.ControllerAction)]
        [HttpGet]
        [Route("_API_Render")]
        public ActionResult _API_Render()

        {
            @model = new ChangePasswordViewModel();
            System.Web.HttpContext.Current.Session["LastEntryPoint_ChangePassword"] = "Render";
            PushToHistory();
            var _masterController = new DemonstratorApp.UI.Controllers.MasterPage.MasterPageController(@model);
            _masterController.ExecuteRender();
            var redirectInfo = ExecuteRender();
            return redirectInfo;
        }

        [CustomControllerActionFilter(CausesValidation=true, ActionName="ChangePassword", ClaimType = ClaimTypes.ControllerAction)]
        [HttpPost]
        [Route("ChangePassword")]
        public ActionResult ChangePassword()

        {
            var _data = _LoadViewModel();
            var _failedValidationsResult = GetFailedDataValidationsResult();
            if (_failedValidationsResult != null) return _failedValidationsResult;
            var redirectInfo = ExecuteChangePassword();
            return redirectInfo;
        }

        #endregion
        #region Controller Actions Implementation
        /*<ControllerActionImplementation:Render:1/>*/
        public ActionResult ExecuteRender()
        {
            if (_parentController == null) _parentController = new MasterPage.MasterPageController(new  DemonstratorApp.UI.ViewModels.MasterPage.MasterPageViewModel());
            ((MasterPage.MasterPageController) _parentController).ExecuteRender();
            ActionResult _result = null;
            @model.Title = null;
            return _result;
        }
        /*<ControllerActionImplementation:ChangePassword:1/>*/
        public ActionResult ExecuteChangePassword()
        {
            ActionResult _result = null;
            if (@model.txtNewRepeat != @model.txtNew)
            {
                ClientCommand(ClientCommands.SHOW_MESSAGE, BaseViewPage<string>.GetResourceValue("ChangePassword", "RES_CUSTOM_PassError").ToString(), MessageType.Error);
                return null;
            }
            string result = zAppDev.DotNet.Framework.Identity.IdentityHelper.ChangePassword(zAppDev.DotNet.Framework.Identity.IdentityHelper.GetCurrentApplicationUser(), @model.txtCurrent, @model.txtNew);
            if (((((result) == null || (result) == "")) == false))
            {
                ClientCommand(ClientCommands.SHOW_MESSAGE, result, MessageType.Error);
                return null;
            }
            _result = CloseForm();
            return _result;
        }
        #endregion

        public override ActionResult PreActionFilterHook(bool causesValidation, bool listenToEvent, string actionName)
        {
            System.Web.HttpContext.Current.Items["_currentControllerAction"] = actionName;
            if (listenToEvent) return null;
            return null;
        }
        public override ActionResult PostActionFilterHook(bool hasDefaultResultView, bool fillDropDownInitialValues = false)
        {
            if (HasClientResponse())
            {
                viewDTO.ClientResponse = GetClientResponse();
            }
            else
            {
                var _modelDTO = new ChangePasswordViewModelDTO(@model);
                viewDTO.Model = _modelDTO;
            }
            if (!hasDefaultResultView)
            {
                var __result = Json(new
                {
                    Type = "Data",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            return View("ChangePassword");
        }

        #region Data Validations


        private ActionResult GetFailedDataValidationsResult()
        {
            try
            {
                RunDataValidations();
                if (!viewDTO.DataValidationsHaveFailed) return null;
                var __result = Json(new
                {
                    Type = "RuleEvaluation",Data = viewDTO.Serialize()
                }, JsonRequestBehavior.AllowGet);
                __result.MaxJsonLength = int.MaxValue;
                return __result;
            }
            catch (Exception e)
            {
                _logger.Error("!!! DANGER: Error while evaluating Data Validations !!!", e);
                log4net.LogManager.GetLogger(this.GetType()).Error("Form: ChangePassword, Action: " + System.Web.HttpContext.Current.Items["_currentControllerAction"], e);
                //throw;
                return null;
            }
        }
        public List<RuleResult> RunDataValidations()
        {
            viewDTO.RuleEvaluations.DataValidations.Add(CurrentPasswordEmptyValidation());
            viewDTO.RuleEvaluations.DataValidations.Add(NewPasswordEmptyValidation());
            viewDTO.RuleEvaluations.DataValidations.Add(RepeatPasswordEmptyValidation());
            var masterPageDataValidations = (_parentController as Controllers.MasterPage.MasterPageController).RunDataValidations();
            if (masterPageDataValidations?.Any() == true)
            {
                viewDTO.RuleEvaluations.DataValidations.AddRange(masterPageDataValidations);
            }
            return viewDTO.RuleEvaluations.DataValidations;
        }


        /*<DataValidation:CurrentPasswordEmptyValidation:1/>*/
        [Rule(RuleType.DataValidation, EvalTime.OnSubmit)]
        public RuleResult CurrentPasswordEmptyValidation()
        {
            var __evaluations = new List<RuleEvaluation>();
            Func<int[], bool> __evaluation = (indexes) =>
            {
                /*<DataValidationCondition:CurrentPasswordEmptyValidation:2/>*/
                return (@model.txtCurrent == null || @model.txtCurrent.Trim() == "");
            };
            Func<string> __message = () =>
            {
                /*<DataValidationMesage:CurrentPasswordEmptyValidation:2/>*/
                return BaseViewPage<string>.GetResourceValue("ChangePassword", "RES_DATAVALIDATION_MESSAGE_CurrentPasswordEmpty").ToString();
            };
            var __indexes = new int[] {};
            var __status = __evaluation.Invoke(__indexes);
            var __messageToSend = __status == true ? __message.Invoke() : null;
            __evaluations.Add(new RuleEvaluation
            {
                Status = __status,
                Expression = __messageToSend,
                Indexes = __indexes,
                DataValidationMessageType = DataValidationMessageType.ERROR
            });
            return new RuleResult
            {
                Name = "CurrentPasswordEmptyValidation",
                Evaluations = __evaluations
            };
        }


        /*<DataValidation:NewPasswordEmptyValidation:1/>*/
        [Rule(RuleType.DataValidation, EvalTime.OnSubmit)]
        public RuleResult NewPasswordEmptyValidation()
        {
            var __evaluations = new List<RuleEvaluation>();
            Func<int[], bool> __evaluation = (indexes) =>
            {
                /*<DataValidationCondition:NewPasswordEmptyValidation:2/>*/
                return (@model.txtNew == null || @model.txtNew.Trim() == "");
            };
            Func<string> __message = () =>
            {
                /*<DataValidationMesage:NewPasswordEmptyValidation:2/>*/
                return BaseViewPage<string>.GetResourceValue("ChangePassword", "RES_DATAVALIDATION_MESSAGE_NewPasswordEmpty").ToString();
            };
            var __indexes = new int[] {};
            var __status = __evaluation.Invoke(__indexes);
            var __messageToSend = __status == true ? __message.Invoke() : null;
            __evaluations.Add(new RuleEvaluation
            {
                Status = __status,
                Expression = __messageToSend,
                Indexes = __indexes,
                DataValidationMessageType = DataValidationMessageType.ERROR
            });
            return new RuleResult
            {
                Name = "NewPasswordEmptyValidation",
                Evaluations = __evaluations
            };
        }


        /*<DataValidation:RepeatPasswordEmptyValidation:1/>*/
        [Rule(RuleType.DataValidation, EvalTime.OnSubmit)]
        public RuleResult RepeatPasswordEmptyValidation()
        {
            var __evaluations = new List<RuleEvaluation>();
            Func<int[], bool> __evaluation = (indexes) =>
            {
                /*<DataValidationCondition:RepeatPasswordEmptyValidation:2/>*/
                return (@model.txtNewRepeat == null || @model.txtNewRepeat.Trim() == "");
            };
            Func<string> __message = () =>
            {
                /*<DataValidationMesage:RepeatPasswordEmptyValidation:2/>*/
                return BaseViewPage<string>.GetResourceValue("ChangePassword", "RES_DATAVALIDATION_MESSAGE_RepeatPasswordEmpty").ToString();
            };
            var __indexes = new int[] {};
            var __status = __evaluation.Invoke(__indexes);
            var __messageToSend = __status == true ? __message.Invoke() : null;
            __evaluations.Add(new RuleEvaluation
            {
                Status = __status,
                Expression = __messageToSend,
                Indexes = __indexes,
                DataValidationMessageType = DataValidationMessageType.ERROR
            });
            return new RuleResult
            {
                Name = "RepeatPasswordEmptyValidation",
                Evaluations = __evaluations
            };
        }

        #endregion
    }
}
