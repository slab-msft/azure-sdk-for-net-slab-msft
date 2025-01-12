// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Container App container scaling rule.
/// </summary>
public partial class ContainerAppScaleRule : ProvisionableConstruct
{
    /// <summary>
    /// Scale Rule Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Azure Queue based scaling.
    /// </summary>
    public ContainerAppQueueScaleRule AzureQueue 
    {
        get { Initialize(); return _azureQueue!; }
        set { Initialize(); AssignOrReplace(ref _azureQueue, value); }
    }
    private ContainerAppQueueScaleRule? _azureQueue;

    /// <summary>
    /// Custom scale rule.
    /// </summary>
    public ContainerAppCustomScaleRule Custom 
    {
        get { Initialize(); return _custom!; }
        set { Initialize(); AssignOrReplace(ref _custom, value); }
    }
    private ContainerAppCustomScaleRule? _custom;

    /// <summary>
    /// HTTP requests based scaling.
    /// </summary>
    public ContainerAppHttpScaleRule Http 
    {
        get { Initialize(); return _http!; }
        set { Initialize(); AssignOrReplace(ref _http, value); }
    }
    private ContainerAppHttpScaleRule? _http;

    /// <summary>
    /// Tcp requests based scaling.
    /// </summary>
    public ContainerAppTcpScaleRule Tcp 
    {
        get { Initialize(); return _tcp!; }
        set { Initialize(); AssignOrReplace(ref _tcp, value); }
    }
    private ContainerAppTcpScaleRule? _tcp;

    /// <summary>
    /// Creates a new ContainerAppScaleRule.
    /// </summary>
    public ContainerAppScaleRule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerAppScaleRule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _azureQueue = DefineModelProperty<ContainerAppQueueScaleRule>("AzureQueue", ["azureQueue"]);
        _custom = DefineModelProperty<ContainerAppCustomScaleRule>("Custom", ["custom"]);
        _http = DefineModelProperty<ContainerAppHttpScaleRule>("Http", ["http"]);
        _tcp = DefineModelProperty<ContainerAppTcpScaleRule>("Tcp", ["tcp"]);
    }
}
