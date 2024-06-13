terraform {
  backend "s3" {}
}

module "bedrock" {
  source = "github.com/eduardobrl/bedrock_with_function_calling_module"
  instructions     = "You are an healpful assistant that assist users of a clinic through text chat to book exams. You have access to tools tha allow consulting and scheduling exams."
  foundation_model = "amazon.titan-text-premier-v1:0"
  app_name = "maracai_assistant"
  alias_name = "prod"
  functions = [
    {
        name = "exam_function"
        handler = "index.handler"
        schema = "out/exams_lambda/schema.yml"
        filename = "out/exams_lambda/code.zip"
        runtime = "dotnet8"
    }
  ]
}