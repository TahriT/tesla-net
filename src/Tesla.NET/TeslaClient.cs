﻿// Copyright (c) 2018 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Tesla.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Tesla.NET.Models;
    using Tesla.NET.Requests;

    /// <inheritdoc cref="ITeslaClient" />
    public class TeslaClient : TeslaClientBase, ITeslaClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeslaClient"/> class.
        /// </summary>
        /// <param name='handlers'>Optional. The handlers to add to the HTTP client pipeline.</param>
        public TeslaClient(params HttpMessageHandler[] handlers)
            : base(handlers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeslaClient"/> class.
        /// </summary>
        /// <param name="baseUri">The <see cref="TeslaClientBase.BaseUri"/> of the Tesla Owner API.</param>
        /// <param name='handlers'>Optional. The handlers to add to the HTTP client pipeline.</param>
        public TeslaClient(Uri baseUri, params HttpMessageHandler[] handlers)
            : base(baseUri, handlers)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeslaClient"/> class.
        /// </summary>
        /// <param name='client'>The <see cref="TeslaClientBase.Client"/>.</param>
        public TeslaClient(HttpClient client)
            : base(client)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TeslaClient"/> class.
        /// </summary>
        /// <param name="baseUri">The <see cref="TeslaClientBase.BaseUri"/> of the Tesla Owner API.</param>
        /// <param name='client'>The <see cref="TeslaClientBase.Client"/>.</param>
        public TeslaClient(Uri baseUri, HttpClient client)
            : base(baseUri, client)
        {
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IReadOnlyList<IVehicle>>>> GetVehiclesAsync(
            CancellationToken cancellationToken = default)
        {
            return Client.GetVehiclesAsync(BaseUri, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IReadOnlyList<IVehicle>>>> GetVehiclesAsync(
            string accessToken,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken));

            return Client.GetVehiclesAsync(BaseUri, accessToken, cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IChargeState>>> GetChargeStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default)
        {
            return Client.GetChargeStateAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IChargeState>>> GetChargeStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken));

            return Client.GetChargeStateAsync(BaseUri, vehicleId, accessToken, cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IDriveState>>> GetDriveStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default)
        {
            return Client.GetDriveStateAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IDriveState>>> GetDriveStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken));

            return Client.GetDriveStateAsync(BaseUri, vehicleId, accessToken, cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IVehicleState>>> GetVehicleStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default)
        {
            return Client.GetVehicleStateAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IVehicleState>>> GetVehicleStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrWhiteSpace(accessToken))
                throw new ArgumentNullException(nameof(accessToken));

            return Client.GetVehicleStateAsync(BaseUri, vehicleId, accessToken, cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<IVehicle>>> WakeUpAsync(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.WakeUpAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> StartAutoConditioning(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.StartAutoConditioningAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> StopAutoConditioning(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.StopAutoConditioningAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SetTemps(long vehicleId, double driverTemp, double passengerTemp, CancellationToken cancellationToken = default)
        {
            return Client.SetTempsAsync(BaseUri, vehicleId, driverTemp, passengerTemp, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SeatHeaterRequest(long vehicleId, int heater, int level, CancellationToken cancellationToken = default)
        {
            return Client.SeatHeaterRequestAsync(BaseUri, vehicleId, heater, level, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SteeringWheelHeaterRequest(long vehicleId, bool on, CancellationToken cancellationToken = default)
        {
            return Client.SteeringWheelHeaterRequestAsync(BaseUri, vehicleId, on, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargePortOpen(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.ChargePortOpenAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargePortClose(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.ChargePortCloseAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargeStart(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.ChargeStartAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargeStop(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.ChargeStopAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SetChargeLimit(long vehicleId, int percent, CancellationToken cancellationToken = default)
        {
            return Client.SetChargeLimitAsync(BaseUri, vehicleId, percent, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> DoorUnlock(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.DoorUnlockAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> DoorLock(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.DoorLockAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ActuateTrunk(long vehicleId, string whichTrunk, CancellationToken cancellationToken = default)
        {
            return Client.ActuateTrunkAsync(BaseUri, vehicleId, whichTrunk, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> HonkHorn(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.HonkHornAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> FlashLights(long vehicleId, CancellationToken cancellationToken = default)
        {
            return Client.FlashLightsAsync(BaseUri, vehicleId, cancellationToken: cancellationToken);
        }

        /// <inheritdoc />
        public Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SunRoofControl(long vehicleId, string state, CancellationToken cancellationToken = default)
        {
            return Client.SunRoofControlAsync(BaseUri, vehicleId, state, cancellationToken: cancellationToken);
        }
    }
}
