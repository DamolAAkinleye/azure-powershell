$TestRecordingFile = Join-Path $PSScriptRoot 'Get-AzResourceGroup.Recording.json'
. (Join-Path $PSScriptRoot '..\generated\runtime' 'HttpPipelineMocking.ps1')

Describe 'Get-AzResourceGroup' {
    It 'GetById' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetByTag' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'GetByTagNameAndValue' {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
