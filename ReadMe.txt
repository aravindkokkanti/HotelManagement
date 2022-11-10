N-LAYERE ARCHITECTURE CONTAIN SINGLE SERVER 
N- TIRE ARCHITECTURE CONTAIN MORE THAN 3 SERVERS


https://www.c-sharpcorner.com/interview-question/what-is-difference-between-ntier-vs-nlayer-architecture

https://www.c-sharpcorner.com/UploadFile/09953d/mvc-application-using-n-tier-architecture/

https://www.youtube.com/watch?v=Hqj8Xxebf9Y

https://www.geeksforgeeks.org/basic-crud-create-read-update-delete-in-asp-net-mvc-using-c-sharp-and-entity-framework/

for roslyn and bin files use below code paste on presentation layer that project first unload and paste after complete relode project

https://stackoverflow.com/questions/32780315/could-not-find-a-part-of-the-path-bin-roslyn-csc-exe

or 
use

<Target Name="CopyRoslynFiles" AfterTargets="AfterBuild" Condition="!$(Disable_CopyWebApplication) And '$(OutDir)' != '$(OutputPath)'">
    <ItemGroup>
      <RoslynFiles Include="$(CscToolPath)\*" />
    </ItemGroup>
    <MakeDir Directories="$(WebProjectOutputDir)\bin\roslyn" />
    <Copy SourceFiles="@(RoslynFiles)" DestinationFolder="$(WebProjectOutputDir)\bin\roslyn" SkipUnchangedFiles="true" Retries="$(CopyRetryCount)" RetryDelayMilliseconds="$(CopyRetryDelayMilliseconds)" />
</Target>



