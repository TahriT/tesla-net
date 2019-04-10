// Copyright (c) 2018 James Skimming. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

namespace Tesla.NET
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;
    using Tesla.NET.Models;

    /// <summary>
    /// Client for the Tesla Owner API.
    /// </summary>
    public interface ITeslaClient
    {
        /// <summary>
        /// Gets the vehicles associated with an account.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>The vehicles associated with an account.</returns>
        Task<IMessageResponse<IResponseDataWrapper<IReadOnlyList<IVehicle>>>> GetVehiclesAsync(
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the vehicles associated with an account.
        /// </summary>
        /// <param name="accessToken">
        /// The access token used to authenticate the request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>The vehicles associated with an account.</returns>
        Task<IMessageResponse<IResponseDataWrapper<IReadOnlyList<IVehicle>>>> GetVehiclesAsync(
            string accessToken,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IChargeState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IChargeState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IChargeState>>> GetChargeStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IChargeState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="accessToken">
        /// The access token used to authenticate the request; can be <see langword="null"/> if the authentication is
        /// added by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IChargeState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IChargeState>>> GetChargeStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IDriveState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IDriveState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IDriveState>>> GetDriveStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IDriveState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="accessToken">
        /// The access token used to authenticate the request; can be <see langword="null"/> if the authentication is
        /// added by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IDriveState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IDriveState>>> GetDriveStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IVehicleState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IVehicleState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IVehicleState>>> GetVehicleStateAsync(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets the <see cref="IVehicleState"/> of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="accessToken">
        /// The access token used to authenticate the request; can be <see langword="null"/> if the authentication is
        /// added by default.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IVehicleState"/> of the <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IVehicleState>>> GetVehicleStateAsync(
            long vehicleId,
            string accessToken,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Wakes up the car from a sleeping state of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="IVehicle"/> with the specified <see cref="IVehicle.Id"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<IVehicle>>> WakeUpAsync(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Start the climate control (HVAC) system of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>. Will cool or heat automatically, depending on set temperature.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> StartAutoConditioning(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Stop the climate control (HVAC) system of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> StopAutoConditioning(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets the target temperature for the climate control (HVAC) system of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// Note: The parameters are always in celsius, regardless of the region the car is in or the display settings of the car.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="driverTemp">The temperature in Celcius to set for the driver's side.</param>
        /// <param name="passengerTemp">The temperature in Celcius to set for the passenger's side.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SetTemps(
            long vehicleId,
            double driverTemp,
            double passengerTemp,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets the specified seat's heater level of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="heater">The desired seat to heat. (0-5). 0=Driver,1=Passenger,2=Rear left,4=Rear center,5=Rear right</param>
        /// <param name="level">The desired level for the heater. (0-3).</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SeatHeaterRequest(
            long vehicleId,
            int heater,
            int level,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Turn steering wheel heater on or off of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="on">True to turn on, false to turn off.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SteeringWheelHeaterRequest(
            long vehicleId,
            bool on,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Opens the charge port of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargePortOpen(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// For vehicles with a motorized charge port, this closes it. For the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargePortClose(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// If the car is plugged in but not currently charging, this will start charging the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargeStart(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// If the car is currently charging, this will stop charging the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ChargeStop(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Sets the charge limit to a custom value of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="percent">The percentage the battery will charge until.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SetChargeLimit(
            long vehicleId,
            int percent,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Unlocks the doors to the car of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/> Extends the handles on the S and X.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> DoorUnlock(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Locks the doors to the car of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/> Retracts the handles on the S and X, if they are extended.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> DoorLock(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Opens either the front or rear trunk of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/> On the Model S and X, it will also close the rear trunk.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="whichTrunk">Which trunk to open. Only valid options are "rear" and "front".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> ActuateTrunk(
            long vehicleId,
            string whichTrunk,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Honks the horn twice of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> HonkHorn(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Flashes the headlights once of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> FlashLights(
            long vehicleId,
            CancellationToken cancellationToken = default);

        /// <summary>
        /// Controls the panoramic sunroof of the <see cref="IVehicle"/> with the specified
        /// <see cref="IVehicle.Id"/>. This only works on Model S.
        /// </summary>
        /// <param name="vehicleId">The unique <see cref="IVehicle.Id"/> of a <see cref="IVehicle"/>.</param>
        /// <param name="state">The amount to open the sunroof. Currently this only allows the values "vent" and "close".</param>
        /// <param name="cancellationToken">A <see cref="CancellationToken" /> to observe while waiting for a task to
        /// complete.</param>
        /// <returns>
        /// The <see cref="ICommandResult"/>.
        /// </returns>
        Task<IMessageResponse<IResponseDataWrapper<ICommandResult>>> SunRoofControl(
            long vehicleId,
            string state,
            CancellationToken cancellationToken = default);
    }
}
