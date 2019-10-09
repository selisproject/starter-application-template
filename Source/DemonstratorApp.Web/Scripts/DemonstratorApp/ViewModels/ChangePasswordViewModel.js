var __extends = (this && this.__extends) || (function () {
    var extendStatics = Object.setPrototypeOf ||
        ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
        function (d, b) { for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p]; };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
// Copyright (c) CLMS. All rights reserved.
// Licensed under the AGPL-3.0 license. See LICENSE file in the project root for full license information.
// This source file was autogenerated by zAppDev(r).
var DemonstratorApp;
(function (DemonstratorApp) {
    var ViewModels;
    (function (ViewModels) {
        var ChangePassword;
        (function (ChangePassword) {
            var ChangePasswordViewModel = (function (_super) {
                __extends(ChangePasswordViewModel, _super);
                function ChangePasswordViewModel() {
                    var _this = _super.call(this) || this;
                    _this._clientPostedProps = null;
                    if (_this._members == null) {
                        _this._members = {
                            txtCurrent: true, txtNew: true, txtNewRepeat: true
                        };
                    }
                    else {
                        _this._members["txtCurrent"] = true;
                        _this._members["txtNew"] = true;
                        _this._members["txtNewRepeat"] = true;
                    }
                    return _this;
                }
                ChangePasswordViewModel._lightCast = function (instance) {
                    if (instance == null)
                        return;
                    return instance;
                };
                ChangePasswordViewModel._initializeFrom = function (original, ignoreReadOnlyProperties, context) {
                    if (ignoreReadOnlyProperties === void 0) { ignoreReadOnlyProperties = false; }
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return null;
                    // if (context.Has(original)) {
                    //    return context.Get(original);
                    // }
                    var result = new ChangePasswordViewModel();
                    if (context != null && context.fillDb == true) {
                        context.addToDb(original);
                    }
                    result._hydrateChangePasswordViewModel(original, ignoreReadOnlyProperties, context);
                    // context.Add(original, result);
                    return result;
                };
                ChangePasswordViewModel.prototype._hydrateChangePasswordViewModel = function (original, ignoreReadOnlyProperties, context) {
                    if (context === void 0) { context = new Joove.DTOHelper(); }
                    if (original == null)
                        return;
                    this._hydrateMasterPageViewModel(original, ignoreReadOnlyProperties, context);
                    if (original._key !== undefined)
                        this._key = original._key;
                    if (original._clientKey !== undefined)
                        this._clientKey = original._clientKey;
                    if (original._originalTypeClassName !== undefined)
                        this._originalTypeClassName = original._originalTypeClassName;
                    if (original._typeHash !== undefined)
                        this._typeHash = original._typeHash;
                    if (original.txtCurrent !== undefined)
                        this.txtCurrent = original.txtCurrent;
                    if (original.txtNew !== undefined)
                        this.txtNew = original.txtNew;
                    if (original.txtNewRepeat !== undefined)
                        this.txtNewRepeat = original.txtNewRepeat;
                    this._reduceData = function (ignoreReadOnlyProperties) {
                        var reduced = ChangePasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                        ChangePasswordViewModel._deleteDropDownInitialValues(reduced);
                        return reduced;
                    };
                }; /* end _initializeFrom() */
                ChangePasswordViewModel.prototype._reduceData = function (ignoreReadOnlyProperties) {
                    var reduced = ChangePasswordViewModel._initializeFrom(this, ignoreReadOnlyProperties);
                    ChangePasswordViewModel._deleteDropDownInitialValues(reduced);
                    return reduced;
                };
                ChangePasswordViewModel._deleteDropDownInitialValues = function (reduced) {
                    if (reduced == null)
                        return;
                    DemonstratorApp.ViewModels.MasterPage.MasterPageViewModel._deleteDropDownInitialValues(reduced);
                };
                ChangePasswordViewModel.prototype.hasMember = function (propertyName) {
                    var result = this._members[propertyName];
                    if (result == null) {
                        return false;
                    }
                    return this._members[propertyName];
                };
                return ChangePasswordViewModel;
            }(DemonstratorApp.ViewModels.MasterPage.MasterPageViewModel));
            ChangePassword.ChangePasswordViewModel = ChangePasswordViewModel;
        })(ChangePassword = ViewModels.ChangePassword || (ViewModels.ChangePassword = {}));
    })(ViewModels = DemonstratorApp.ViewModels || (DemonstratorApp.ViewModels = {}));
})(DemonstratorApp || (DemonstratorApp = {}));
