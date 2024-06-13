variable "foundation_model" {
  description = "The name foundation model to use for the Bedrock agent"
  type        = string
  default     = "claude-v1"
}

variable "instructions" {
  description = "The instructions for bedrock agent"
  type        = string
  default     = "claude-v1"
}

variable "app_name" {
  description = "The name of ther service"
  type        = string
}

variable "lambda_handler" {
  description = "Handler for lambda functions"
  type        = string
  default     = "lambda_function.lambda_handler"
}


variable "lambda_runtime" {
  description = "Runtime for lambda functions"
  type        = string
  default     = "python3.8"
}