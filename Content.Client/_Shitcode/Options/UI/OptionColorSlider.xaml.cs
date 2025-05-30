// SPDX-FileCopyrightText: 2025 Aiden <28298836+Aidenkrz@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 Aidenkrz <aiden@djkraz.com>
// SPDX-FileCopyrightText: 2025 Misandry <mary@thughunt.ing>
// SPDX-FileCopyrightText: 2025 Ted Lukin <66275205+pheenty@users.noreply.github.com>
// SPDX-FileCopyrightText: 2025 gus <august.eymann@gmail.com>
//
// SPDX-License-Identifier: AGPL-3.0-or-later

using Content.Client.Options.UI;
using Robust.Client.AutoGenerated;
using Robust.Client.UserInterface;

namespace Content.Client._Shitcode.Options.UI;

/// <summary>
/// Standard UI control used for color sliders in the options menu. Intended for use with <see cref="OptionsTabControlRow"/>.
/// </summary>
/// <seealso cref="OptionsTabControlRow.AddOptionColorSlider"/>
[GenerateTypedNameReferences]
public sealed partial class OptionColorSlider : Control
{
    /// <summary>
    /// The text describing what this slider affects.
    /// </summary>
    public string? Title
    {
        get => TitleLabel.Text;
        set => TitleLabel.Text = value;
    }

    /// <summary>
    /// The example text showing the current color of the slider.
    /// </summary>
    public string? Example
    {
        get => ExampleLabel.Text;
        set => ExampleLabel.Text = value;
    }
}